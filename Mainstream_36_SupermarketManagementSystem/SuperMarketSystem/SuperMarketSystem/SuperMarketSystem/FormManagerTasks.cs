using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarketSystem
{
    public partial class FormManagerTasks : Form
    {
        public FormManagerTasks()
        {
            InitializeComponent();
        }

        private void FormManagerTasks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            FormControlPrices controlPricesForm = new FormControlPrices();
            controlPricesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            FormManageExpiredProducts ManageExpiredProducts = new FormManageExpiredProducts();
            ManageExpiredProducts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            FormOrderProducts OrderProductsForm = new FormOrderProducts();
            OrderProductsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            FormGradingEmployees FormGradingEmployees = new FormGradingEmployees();
            FormGradingEmployees.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while(Program.formStack.Count > 1)
            {
                Program.formStack.Pop();
            }
            this.Hide();
            Welcome_form form = (Welcome_form)Program.formStack.Pop();
            form.Show();
        }

        private void ManagerViewEmpReportBtn_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            EmployeesReportForm form = new EmployeesReportForm();
            form.Show();
        }

        private void ManagerViewProductsReportBtn_Click(object sender, EventArgs e)
        {
            Program.formStack.Push(this);
            this.Hide();
            ProductsReportForm form = new ProductsReportForm();
            form.Show();
        }
    }
}
