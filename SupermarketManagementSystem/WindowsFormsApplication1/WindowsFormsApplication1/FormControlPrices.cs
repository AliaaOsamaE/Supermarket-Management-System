using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace WindowsFormsApplication1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadProducts_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=sys;password=Administrator1;DBA Privilege = SYSDBA;";
            string cmdstr = @"Select PRODUCTS.PRODUCT_ID , PRODUCTS.PRODUCT_NAME , PRODUCTS.PRODUCT_PRICE 
                                from PRODUCTS , ProductsCategory
                                where PRODUCTS.Category_ID = ProductsCategory.Category_ID
                                and ProductsCategory.Category_Name =: CN";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("CN", ProductCategory.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            ds.Tables[0].PrimaryKey = new DataColumn[] { 
            ds.Tables[0].Columns["Product_ID"], 
            ds.Tables[0].Columns["Product_Name"] 
        };

            dataGridView1.Columns["PRODUCT_ID"].ReadOnly = true;
            dataGridView1.Columns["PRODUCT_NAME"].ReadOnly = true;
        }

       

        private void SaveNewPricesbutton_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Prices updated");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagerTasks ManagerTasksform = (FormManagerTasks)Program.formStack.Pop();
            ManagerTasksform.Show();
        }
      
    }
}
