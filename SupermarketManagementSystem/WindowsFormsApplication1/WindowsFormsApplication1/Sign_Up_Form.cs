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
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Sign_Up_Form : Form
    {
        string ordb = "Data Source=ORCL;User Id=sys;Password=Administrator1; DBA Privilege = SYSDBA;";
        OracleConnection conn;
        public Sign_Up_Form()
        {
            InitializeComponent();
            Name_Text_Box.KeyPress += new KeyPressEventHandler(Name_Text_Box_KeyPress);
        }

        private void Sign_Up_Form_Load(object sender, EventArgs e)
        {
            Job_Role_ComboBox.Items.Add("Cashier");
            Job_Role_ComboBox.Items.Add("Clerk");
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            OracleCommand get_max_emp_id = new OracleCommand();
            get_max_emp_id.Connection = conn;
            get_max_emp_id.CommandText = "SELECT MAX(EMP_ID) FROM emp";
            get_max_emp_id.CommandType = CommandType.Text;
            object result = get_max_emp_id.ExecuteScalar();
            int new_emp_id = Convert.ToInt32(result.ToString()) + 1;
            if (Name_Text_Box.TextLength == 0)
            {
                MessageBox.Show("Please Enter Your Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Password_TextBox.TextLength < 8)
            {
                MessageBox.Show("Please Enter A Strong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (RePassword_TextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter your password again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Password_TextBox.Text != RePassword_TextBox.Text)
            {
                MessageBox.Show("Please check the re entered password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Name_Text_Box.TextLength > 0 && Password_TextBox.Text == RePassword_TextBox.Text && Password_TextBox.TextLength >= 8 && RePassword_TextBox.TextLength >= 8)
            {
                if (Job_Role_ComboBox.SelectedItem.ToString() == "Cashier")
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into emp values (:id, :name, :password, :salary, :evaluation, :attendence, :emp_role)";
                    cmd.CommandType = CommandType.Text;

                    // Add parameters with proper initialization
                    cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = new_emp_id;
                    cmd.Parameters.Add(new OracleParameter("name", OracleDbType.Varchar2)).Value = Name_Text_Box.Text;
                    string emp_password = HashPassword(Password_TextBox.Text);
                    cmd.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = emp_password;
                    cmd.Parameters.Add(new OracleParameter("salary", OracleDbType.Double)).Value = 8000.00;
                    cmd.Parameters.Add(new OracleParameter("evaluation", OracleDbType.Varchar2)).Value = "Good";
                    cmd.Parameters.Add(new OracleParameter("attendence", OracleDbType.Int32)).Value = 0;
                    cmd.Parameters.Add(new OracleParameter("emp_role", OracleDbType.Varchar2)).Value = Job_Role_ComboBox.SelectedItem;

                    int r = cmd.ExecuteNonQuery();

                    if (r != -1)
                    {
                        MessageBox.Show("Congratulations for your Job \n Please Keep your ID and Password a Secert.\n Your Id is " + new_emp_id, "new employee is added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Welcome_form form = new Welcome_form();
                        form.Show();
                    }
                }
                else if (Job_Role_ComboBox.SelectedItem.ToString() == "Clerk")
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into emp values (:id, :name, :password, :salary, :evaluation, :attendence, :emp_role)";
                    cmd.CommandType = CommandType.Text;

                    // Add parameters with proper initialization
                    cmd.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = new_emp_id;
                    cmd.Parameters.Add(new OracleParameter("name", OracleDbType.Varchar2)).Value = Name_Text_Box.Text;
                    string emp_password = HashPassword(Password_TextBox.Text);
                    cmd.Parameters.Add(new OracleParameter("password", OracleDbType.Varchar2)).Value = emp_password;
                    cmd.Parameters.Add(new OracleParameter("salary", OracleDbType.Double)).Value = 8000.00;
                    cmd.Parameters.Add(new OracleParameter("evaluation", OracleDbType.Varchar2)).Value = "Good";
                    cmd.Parameters.Add(new OracleParameter("attendence", OracleDbType.Int32)).Value = 0;
                    cmd.Parameters.Add(new OracleParameter("emp_role", OracleDbType.Varchar2)).Value = Job_Role_ComboBox.SelectedItem;
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Congratulations for your Job \n Please Keep your ID and Password a Secert.\n Your Id is " + new_emp_id, "new employee is added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Hide();
                        Welcome_form form = new Welcome_form();
                        form.Show();
                    }
                }
            }

        }

        private static string HashPassword(string password)
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

        private void Sign_Up_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void Name_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character entered is not a digit and not a control character (like backspace)
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's a digit, handle the event and suppress the character
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_form form = (Welcome_form)Program.formStack.Pop();
            form.Show();

        }
    }
}
