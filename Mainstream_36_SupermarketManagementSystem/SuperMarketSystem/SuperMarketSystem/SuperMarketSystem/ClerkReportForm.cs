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

namespace SuperMarketSystem
{
    public partial class ClerkReportForm : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr";
        OracleConnection categoriesConnection;
        OracleConnection productsConnection;
        ClerkRetrieveDataReport cr;
        public ClerkReportForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ClerkReportForm_Load(object sender, EventArgs e)
        {
            categoriesConnection = new OracleConnection(ordb);
            categoriesConnection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = categoriesConnection;
            cmd.CommandText = "select Category_Name from ProductsCategory";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CategoryNameCMBBox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void CategoryNameCMBBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductNameCMBBox.Items.Clear();
            ProductNameCMBBox.Text = "";
            productsConnection = new OracleConnection(ordb);
            productsConnection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = productsConnection;
            cmd.CommandText = "SELECT p.product_name from products p, productscategory pc where p.category_id = pc.category_id and pc.category_name =:categoryName";
            cmd.Parameters.Add("categoryName", CategoryNameCMBBox.SelectedItem.ToString());
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ProductNameCMBBox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void DisplayInfoBtn_Click(object sender, EventArgs e)
        {
            if (CategoryNameCMBBox.SelectedItem == null)
            {
                MessageBox.Show("please select a category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ProductNameCMBBox.SelectedItem == null)
                {
                    MessageBox.Show("please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ProductNameCMBBox.SelectedItem == null)
            {
                MessageBox.Show("please select a product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cr = new ClerkRetrieveDataReport();
                cr.SetParameterValue(0, ProductNameCMBBox.Text);
                cr.SetParameterValue(1, CategoryNameCMBBox.Text);
                crystalReportViewer1.ReportSource = cr;
            }
        }

        private void ClerkBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_form form = (Welcome_form)Program.formStack.Pop();
            form.Show();
        }
    }
}
