using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Text.RegularExpressions;

namespace SuperMarketSystem
{
    public partial class FormControlPrices : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public FormControlPrices()
        {
            InitializeComponent();
        }

        private void FormControlPrices_Load(object sender, EventArgs e)
        {

        }

        private void LoadProducts_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=hr;password=hr;";

            string cmdstr = @"Select PRODUCTS.PRODUCT_ID , PRODUCTS.PRODUCT_NAME , PRODUCTS.PRODUCT_PRICE 
                            from PRODUCTS , ProductsCategory
                            where PRODUCTS.Category_ID = ProductsCategory.Category_ID
                            and ProductsCategory.Category_Name =: CN";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("CN", ProductCategory.Text);
            ds = new DataSet();
            if (string.IsNullOrWhiteSpace(ProductCategory.Text))
            {
                MessageBox.Show("Please Enter Product Category");
            }
            else
            {
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                ds.Tables[0].PrimaryKey = new DataColumn[]
                {
                    ds.Tables[0].Columns["Product_ID"],
                    ds.Tables[0].Columns["Product_Name"]
                };
                dataGridView1.Columns["PRODUCT_ID"].ReadOnly = true;
                dataGridView1.Columns["PRODUCT_NAME"].ReadOnly = true;
            }
        }

        private void SaveNewPricesbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductCategory.Text))
            {
                MessageBox.Show("Please Enter Product Category");
            }
            else if (dataGridView1.DataSource == null || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data available in DataGridView");
            }
            else
            {

                bool hasInvalidPrice = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Regex regex = new Regex("[^a-zA-Z]");
                    //regex.IsMatch(value)

                    if (row.Cells["Product_Price"].Value != null && regex.IsMatch(row.Cells["Product_Price"].Value.ToString()))
                    {
                        string priceString = row.Cells["Product_Price"].Value.ToString();
                        decimal price;

                        try
                        {
                            price = decimal.Parse(priceString);

                            if (price <= 0)
                            {
                                hasInvalidPrice = true;
                                break;
                            }

                        }
                        catch (FormatException)
                        {
                            hasInvalidPrice = true;
                            break;
                        }
                    }
                }
                if (hasInvalidPrice)
                {
                    MessageBox.Show("Please enter positive prices only.");
                }
                else
                {
                    builder = new OracleCommandBuilder(adapter);
                    adapter.Update(ds.Tables[0]);
                    MessageBox.Show("Prices updated");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagerTasks ManagerTasksform = (FormManagerTasks)Program.formStack.Pop();
            ManagerTasksform.Show();
        }
    }
}
