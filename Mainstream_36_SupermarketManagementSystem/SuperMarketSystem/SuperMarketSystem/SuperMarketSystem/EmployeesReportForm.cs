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
    public partial class EmployeesReportForm : Form
    {
        EmployeesrReport cr;
        public EmployeesReportForm()
        {
            InitializeComponent();
        }

        private void EmployeesReportForm_Load(object sender, EventArgs e)
        {
            cr = new EmployeesrReport();

            foreach (ParameterDiscreteValue val in cr.ParameterFields[0].DefaultValues)
            {
                EmployeeRolesCMBBox.Items.Add(val.Value);
            }
        }

        private void ViewEmployeeReportBtn_Click(object sender, EventArgs e)
        {
            if (EmployeeRolesCMBBox.SelectedItem != null)
            {
                cr.SetParameterValue(0, EmployeeRolesCMBBox.Text);
                crystalReportViewer1.ReportSource = cr;
            }
            else
            {
                MessageBox.Show("Please Select A Role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ManagerViewEmpBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagerTasks form = (FormManagerTasks)Program.formStack.Pop();
            form.Show();
        }
    }
}
