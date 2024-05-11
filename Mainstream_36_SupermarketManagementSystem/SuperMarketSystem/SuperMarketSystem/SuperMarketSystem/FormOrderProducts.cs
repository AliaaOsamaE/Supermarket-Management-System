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
    public partial class FormOrderProducts : Form
    {
        string ordb = "Data Source=orcl;User Id=hr;password=hr;";
        OracleConnection conn;
        public FormOrderProducts()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormOrderProducts_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select PRODUCT_NAME from PRODUCTS where Number_Of_Units = 0";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["PRODUCT_NAME"]);
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            int numberOfUnits;
            // Check combobox and textbox are not empty and textbox has valid value
            if (comboBox1.SelectedItem != null && !string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox1.Text, out numberOfUnits))
            {
                if (numberOfUnits > 0)
                {
                    string productName = comboBox1.SelectedItem.ToString();
                    OracleCommand productInfo = new OracleCommand();
                    productInfo.Connection = conn;
                    productInfo.CommandText = "SELECT PRODUCT_ID, PRODUCT_PRICE FROM PRODUCTS WHERE PRODUCT_NAME = :productName";
                    productInfo.Parameters.Add(":productName", OracleDbType.Varchar2).Value = productName;
                    OracleDataReader productInfoReader = productInfo.ExecuteReader();
                    int productID = -1;
                    if (productInfoReader.Read())
                    {
                        object productIdObj = productInfoReader.GetValue(0);
                        if (productIdObj != DBNull.Value)
                        {
                            productID = Convert.ToInt32(productIdObj);
                        }
                        double productPrice = productInfoReader.GetDouble(1);
                        productInfoReader.Close();
                        double totalPrice = productPrice * numberOfUnits;
                        OracleCommand maxId = new OracleCommand();
                        maxId.Connection = conn;
                        maxId.CommandText = "SELECT MAX(ORDER_ID) FROM SUPPLIES";
                        object maxIdObj = maxId.ExecuteScalar();
                        int newOrderId = -1;
                        if (maxIdObj != DBNull.Value)
                        {
                            newOrderId = Convert.ToInt32(maxIdObj) + 1;
                        }
                        OracleCommand insertRow = new OracleCommand();
                        insertRow.Connection = conn;
                        insertRow.CommandText = "INSERT INTO SUPPLIES VALUES (:orderid, :productid,:productName, :numberofunits, :pricepaid)";
                        insertRow.Parameters.Add(":orderid", OracleDbType.Int32).Value = newOrderId;
                        insertRow.Parameters.Add(":productid", OracleDbType.Int32).Value = productID;
                        insertRow.Parameters.Add(":productName", OracleDbType.Varchar2).Value = productName;
                        insertRow.Parameters.Add(":numberofunits", OracleDbType.Int32).Value = numberOfUnits;
                        insertRow.Parameters.Add(":pricepaid", OracleDbType.Decimal).Value = totalPrice;
                        int rowsInserted = insertRow.ExecuteNonQuery();
                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("New supply is ordered with orderid: " + newOrderId + " , total price: " + totalPrice);
                            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                            OracleCommand updateNumberOfUnits = new OracleCommand();
                            updateNumberOfUnits.Connection = conn;
                            updateNumberOfUnits.CommandText = "UPDATE PRODUCTS SET NUMBER_OF_UNITS = :newOrderedUnits WHERE PRODUCT_ID = :productId";
                            // Bind parameters
                            updateNumberOfUnits.Parameters.Add(":newOrderedUnits", OracleDbType.Int32).Value = numberOfUnits;
                            updateNumberOfUnits.Parameters.Add(":productId", OracleDbType.Int32).Value = productID;
                            updateNumberOfUnits.ExecuteNonQuery();
                            OracleCommand updateExpiaryDate = new OracleCommand();
                            updateExpiaryDate.Connection = conn;
                            updateExpiaryDate.CommandText = "UPDATE PRODUCTS SET EXPIARY_DATE = :newExpiaryDate WHERE PRODUCT_ID = :productId";
                            // Bind parameters
                            updateExpiaryDate.Parameters.Add(":newExpiaryDate", OracleDbType.Date).Value = DateTime.Now.AddDays(7);
                            updateExpiaryDate.Parameters.Add(":productId", OracleDbType.Int32).Value = productID;
                            updateExpiaryDate.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert new supply.");
                        }
                    }
                    else
                    {
                        productInfoReader.Close();
                        MessageBox.Show("Failed to retrieve product information for the selected product.");
                    }
                }
                else
                {
                    MessageBox.Show("Number of units must be a positive integer.");
                }
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a product from the ComboBox.");
                }
                if (string.IsNullOrEmpty(textBox1.Text) || !int.TryParse(textBox1.Text, out numberOfUnits))
                {
                    MessageBox.Show("Please enter a valid number in the text box for number of units.");
                }
            }
            textBox1.Text = "";
        }

        private void FormOrderProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagerTasks ManagerTasksform = (FormManagerTasks)Program.formStack.Pop();
            ManagerTasksform.Show();
        }
    }
}
