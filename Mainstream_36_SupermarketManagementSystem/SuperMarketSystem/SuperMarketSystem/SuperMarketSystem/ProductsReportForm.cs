using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SuperMarketSystem
{
    public partial class ProductsReportForm : Form
    {
        ProductsReport cr;
        public ProductsReportForm()
        {
            InitializeComponent();
        }

        private void ViewProductsReportBtn_Click(object sender, EventArgs e)
        {
            int numberOfUnitsParameterValue = 0;
            cr.SetParameterValue(0, numberOfUnitsParameterValue);
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ProductsReportForm_Load(object sender, EventArgs e)
        {
            cr = new ProductsReport();
        }

        private void ManagerProductsViewBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagerTasks form = (FormManagerTasks)Program.formStack.Pop();
            form.Show();
        }
    }
}
