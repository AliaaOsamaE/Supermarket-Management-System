using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;



namespace WindowsFormsApplication1
{
    public partial class FormGradingEmployees : Form
    {
        OracleConnection conn;
        string constr = "Data Source=ORCL;User Id=sys;Password=Administrator1; DBA Privilege = SYSDBA;";
        DataTable dataTable;

        public FormGradingEmployees()
        {
            InitializeComponent();
            dataTable = new DataTable();
            comboBox2.Items.AddRange(new string[] { "Top", "Average", "Poor" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM EMP";

            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                dataTable.Load(dr);
            }

            dataGridView1.Invoke(new Action(() =>
            {
                dataGridView1.DataSource = dataTable;
            }));
            
            PopulateComboBox();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(constr);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE EMP SET SALARY =: salaryValue, EVALUATION =: evalValue WHERE EMP_ID =: selectedEmployeeID";
                string newSalary = textBox1.Text;
                decimal salaryValue;
                if (decimal.TryParse(newSalary, out salaryValue))
                {
                    if (salaryValue > 0)
                    {

                        cmd.Parameters.Add(":salaryValue", OracleDbType.Int32).Value = salaryValue;
                        cmd.Parameters.Add(":evalValue", comboBox2.SelectedItem.ToString());
                        cmd.Parameters.Add(":selectedEmployeeID", OracleDbType.Int32).Value = comboBox1.SelectedItem.ToString();
                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee's data updated successfully.");
                            dataGridView1.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Employee ID not found or no changes made.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid positive salary value.");
                    }
                }
                else
                {
                    MessageBox.Show("Employee ID not found or no salary found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee ID not found or no rank found");
            }

        }
        

        private void PopulateComboBox()
        {
            conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT EMP_ID FROM EMP";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT EVALUATION, SALARY FROM EMP WHERE EMP_ID =: selectedEmployeeID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":SelectedEmployeeID", comboBox1.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                comboBox2.Text = dr[0].ToString();
            }

            else
            {
                MessageBox.Show("Enter a valid ID.");
            }
            

        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            int id = Convert.ToInt32(selectedRow.Cells["EMP_ID"].Value);
            dataGridView1.Rows.Remove(selectedRow);
            conn = new OracleConnection(constr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM EMP WHERE EMP_ID =: selectedEmployeeID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(":selectedEmployeeID", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row deleted successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagerTasks ManagerTasksform = (FormManagerTasks)Program.formStack.Pop();
            ManagerTasksform.Show();
        }

        
     
    }
}
