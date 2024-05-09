using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormManagerTasks : Form
    {
        public FormManagerTasks()
        {
            InitializeComponent();
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
            this.Hide();
            Welcome_form form = new Welcome_form();
            form.Show();
        }
    }
}
