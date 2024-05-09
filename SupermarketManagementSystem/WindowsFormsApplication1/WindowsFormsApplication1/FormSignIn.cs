using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace WindowsFormsApplication1
{
    public partial class FormSignIn : Form
    {
        string ordb ="Data Source=orcl;User Id=sys;password=Administrator1;DBA Privilege = SYSDBA;";
        OracleConnection conn;
        DateTime formLoadTime = DateTime.Now;
        public FormSignIn()
        {
            InitializeComponent();
        }
        static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute hash from the password bytes
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert hashed bytes to hexadecimal string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            int id;

            string password = textBox2.Text;
            string hashedPassword = HashPassword(password);
            if (!string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox1.Text, out id) && password != "")
            {
                OracleCommand empInfo = new OracleCommand();
                empInfo.Connection = conn;
                empInfo.CommandText = "SELECT EMP_ID, EMP_PASSWORD , EMP_ROLE FROM EMP WHERE EMP_ID = :ID and EMP_PASSWORD = :password";
                empInfo.Parameters.Add(":ID", OracleDbType.Decimal).Value = id;
                empInfo.Parameters.Add(":password", OracleDbType.Varchar2).Value = hashedPassword;
                OracleDataReader r = empInfo.ExecuteReader();
                if (r.Read())
                {
                    
                    DateTime currentTime = DateTime.Now;
                    TimeSpan timeDifference = currentTime - formLoadTime;
                    if (timeDifference.TotalMinutes <= 20)
                    {
                        OracleCommand updateAttendance = new OracleCommand();
                        updateAttendance.Connection = conn;
                        updateAttendance.CommandText = "UPDATE EMP SET ATTENDANCE_DAYS = ATTENDANCE_DAYS+1 WHERE EMP_ID = :ID";
                        updateAttendance.Parameters.Add(":ID", OracleDbType.Decimal).Value = id;
                        updateAttendance.ExecuteNonQuery();
                    }
                    else
                    {
                        // Time Expired , will not increment attendance
                        MessageBox.Show("Attendance won't count");
                    }
                    string empRole = r["EMP_ROLE"].ToString();
                    if (empRole == "Clerk")
                    {
                        //go to clerk page
                    }
                    else if (empRole == "Cashier")
                    {
                        this.Hide();
                        Finilizing_customer_payment_form finalizeForm = new Finilizing_customer_payment_form();
                        finalizeForm.Show();
                    }
                    else
                    {
                        this.Hide();
                        FormManagerTasks ManagerTasksform = new FormManagerTasks();
                        Program.formStack.Push(ManagerTasksform);
                        ManagerTasksform.Show();
                    }
                }
                else 
                {
                    MessageBox.Show("Wrong Id or Password");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textBox1.Text) || int.TryParse(textBox1.Text, out id))
                {
                    MessageBox.Show("Please enter a valid id");
                }
                if (password == "")
                {
                    MessageBox.Show("Please enter your password");
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_form form = (Welcome_form)Program.formStack.Pop();
            form.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        

    }
}
