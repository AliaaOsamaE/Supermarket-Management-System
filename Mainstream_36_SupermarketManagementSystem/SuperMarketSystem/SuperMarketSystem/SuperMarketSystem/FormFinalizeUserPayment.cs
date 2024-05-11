using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;

namespace SuperMarketSystem
{
    public partial class FormFinalizeUserPayment : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;
        public FormFinalizeUserPayment()
        {
            InitializeComponent(); 
            CustomerPhoneNumberTextBox.KeyPress += new KeyPressEventHandler(CustomerPhoneNumberTextBox_KeyPress);
        }

        private void FormFinalizeUserPayment_Load(object sender, EventArgs e)
        {
            TransactionData.AutoGenerateColumns = false;

            TransactionData.Columns.Add("Product Name", "Product Name");
            TransactionData.Columns.Add("Category Name", "Category Name");
            TransactionData.Columns.Add("Number of Units", "Number of Units");
            TransactionData.Columns.Add("Price Per Unit", "Price Per Unit");
            TransactionData.Columns.Add("Total Price", "Total Price");

            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetCategoriesName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Categoriesname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CatergoriesComboBox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void FormFinalizeUserPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void CatergoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Category_ID from ProductsCategory where Category_Name=:name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", CatergoriesComboBox.SelectedItem.ToString());
            OracleDataReader dataReader_CatergoryID = cmd.ExecuteReader();
            string ID = "0";
            while (dataReader_CatergoryID.Read())
            {
                ID = dataReader_CatergoryID[0].ToString();
            }
            dataReader_CatergoryID.Close();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select Product_Name from Products where Category_ID=:id AND Number_Of_Units > 0";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", ID);
            ProductComboBox.Items.Clear();
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                ProductComboBox.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Number_Of_Units from Products where Product_Name =: name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", ProductComboBox.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            int number_of_available_product = 0;
            while (dr.Read())
            {
                number_of_available_product = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            QuantityComboBox.Items.Clear();
            for (int i = 1; i <= number_of_available_product; i++)
            {
                QuantityComboBox.Items.Add(i);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (CatergoriesComboBox.SelectedItem != null && ProductComboBox.SelectedItem != null && QuantityComboBox.SelectedItem != null)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select Product_Price from Products where Product_Name =: name";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", ProductComboBox.SelectedItem.ToString());

                OracleDataReader dr = cmd.ExecuteReader();
                double product_price_per_unit = 0;
                while (dr.Read())
                {
                    product_price_per_unit = Convert.ToDouble(dr[0]);
                }
                dr.Close();

                double total_price = product_price_per_unit * Convert.ToDouble(QuantityComboBox.SelectedItem.ToString());

                TransactionData.Rows.Add(ProductComboBox.SelectedItem.ToString(), CatergoriesComboBox.SelectedItem.ToString(), QuantityComboBox.SelectedItem.ToString(), product_price_per_unit.ToString(), total_price.ToString());
            }
            else
            {
                MessageBox.Show("Please Enter the missing values");
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in TransactionData.SelectedRows)
            {
                TransactionData.Rows.RemoveAt(row.Index);
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (TransactionData.Rows.Count == 0)
            {
                MessageBox.Show("No data in the data grid view");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                double totalPrice = Convert.ToDouble(TotalPaymentWithoutPointsTextBox.Text);

                OracleCommand selectMaxCMD = new OracleCommand();
                selectMaxCMD.Connection = conn;
                selectMaxCMD.CommandText = "SELECT MAX(TRANSACTION_ID) FROM transactions";
                selectMaxCMD.CommandType = CommandType.Text;
                object result = selectMaxCMD.ExecuteScalar();

                OracleCommand insertTransactionCMD = new OracleCommand();
                insertTransactionCMD.Connection = conn;

                double customerPreviousPoints = Convert.ToDouble(Customer_previous_points_textbox.Text);


                if (PayWithPointRadioButton.Checked)
                {
                    double totalPriceWithPoints = Convert.ToDouble(TotalPaymentWithPointsTextBox.Text);
                    insertTransactionCMD.CommandText = "insert into transactions values( :transID ,:totalPrice)";
                    insertTransactionCMD.CommandType = CommandType.Text;
                    int newID = Convert.ToInt32(result.ToString()) + 1;
                    insertTransactionCMD.Parameters.Add("transID", newID);
                    insertTransactionCMD.Parameters.Add("totalPrice", totalPriceWithPoints);
                    insertTransactionCMD.ExecuteNonQuery();
                    UpdateUserPoints(true, totalPrice, customerPreviousPoints);
                    conn = new OracleConnection(ordb);
                    conn.Open();
                    foreach (DataGridViewRow row in TransactionData.Rows)
                    {
                        OracleCommand Get_number_of_quantity = new OracleCommand();
                        Get_number_of_quantity.Connection = conn;
                        Get_number_of_quantity.CommandText = "select Product_ID, Number_Of_Units from products where Product_Name=:Pname";
                        Get_number_of_quantity.CommandType = CommandType.Text;
                        string product_name = Convert.ToString(row.Cells[0].Value);
                        Get_number_of_quantity.Parameters.Add("Pname", product_name);
                        int product_id = 0;
                        int number_of_units = 0;
                        OracleDataReader dr = Get_number_of_quantity.ExecuteReader();
                        while (dr.Read())
                        {
                            product_id = Convert.ToInt32(dr[0]);
                            number_of_units = Convert.ToInt32(dr[1]);
                        }
                        dr.Close();
                        int new_number_of_units = number_of_units - Convert.ToInt32(row.Cells[2].Value);
                        OracleCommand update_quantity = new OracleCommand();
                        update_quantity.Connection = conn;
                        update_quantity.CommandText = "update products set number_of_units=:new_number where product_id=:id AND product_name=:name";
                        update_quantity.CommandType = CommandType.Text;
                        update_quantity.Parameters.Add("new_number", new_number_of_units);
                        update_quantity.Parameters.Add("id", product_id);
                        update_quantity.Parameters.Add("name", product_name);
                        update_quantity.ExecuteNonQuery();
                    }
                    QuantityComboBox.Items.Clear();
                    ProductComboBox.Items.Clear();
                    TransactionData.Rows.Clear();
                    CustomerPhoneNumberTextBox.Clear();
                    Customer_previous_points_textbox.Clear();
                    TotalPaymentWithPointsTextBox.Clear();
                    TotalPaymentWithoutPointsTextBox.Clear();

                }
                else if (PayWithoutPointsRadioButton.Checked)
                {

                    insertTransactionCMD.CommandText = "insert into transactions values(:transID , :totalPrice)";
                    insertTransactionCMD.CommandType = CommandType.Text;
                    int newID = Convert.ToInt32(result.ToString()) + 1;
                    insertTransactionCMD.Parameters.Add("transID", newID);
                    insertTransactionCMD.Parameters.Add("totalPrice", totalPrice);
                    insertTransactionCMD.ExecuteNonQuery();
                    UpdateUserPoints(false, totalPrice, customerPreviousPoints);
                    conn = new OracleConnection(ordb);
                    conn.Open();
                    foreach (DataGridViewRow row in TransactionData.Rows)
                    {
                        OracleCommand Get_number_of_quantity = new OracleCommand();
                        Get_number_of_quantity.Connection = conn;
                        Get_number_of_quantity.CommandText = "select Product_ID, Number_Of_Units from products where Product_Name=:Pname";
                        Get_number_of_quantity.CommandType = CommandType.Text;
                        string product_name = Convert.ToString(row.Cells[0].Value);
                        Get_number_of_quantity.Parameters.Add("Pname", product_name);
                        int product_id = 0;
                        int number_of_units = 0;
                        OracleDataReader dr = Get_number_of_quantity.ExecuteReader();
                        while (dr.Read())
                        {
                            product_id = Convert.ToInt32(dr[0]);
                            number_of_units = Convert.ToInt32(dr[1]);
                        }
                        dr.Close();
                        int new_number_of_units = number_of_units - Convert.ToInt32(row.Cells[2].Value);
                        OracleCommand update_quantity = new OracleCommand();
                        update_quantity.Connection = conn;
                        update_quantity.CommandText = "update products set number_of_units=:new_number where product_id=:id AND product_name=:name";
                        update_quantity.CommandType = CommandType.Text;
                        update_quantity.Parameters.Add("new_number", new_number_of_units);
                        update_quantity.Parameters.Add("id", product_id);
                        update_quantity.Parameters.Add("name", product_name);
                        update_quantity.ExecuteNonQuery();
                    }
                    QuantityComboBox.Items.Clear();
                    ProductComboBox.Items.Clear();
                    TransactionData.Rows.Clear();
                    CustomerPhoneNumberTextBox.Clear();
                    Customer_previous_points_textbox.Clear();
                    TotalPaymentWithPointsTextBox.Clear();
                    TotalPaymentWithoutPointsTextBox.Clear();

                }
                else
                {
                    MessageBox.Show("Please choose payment method");
                }

            }
        }

        private void UpdateUserPoints(bool usedPointsForPayment, double totalPrice, double customerPreviousPoints)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand updateUserPointsCMD = new OracleCommand();
            updateUserPointsCMD.Connection = conn;
            double currentTransactionPoints = totalPrice * 10 / 100;
            double updatedCustomerPoints = 0;


            if (usedPointsForPayment)
            {
                if (customerPreviousPoints > totalPrice)
                {
                    updatedCustomerPoints = customerPreviousPoints - totalPrice + currentTransactionPoints;

                }
                else
                {
                    updatedCustomerPoints = currentTransactionPoints;
                }
                updateUserPointsCMD.CommandText = "update customers set points = :newCustomerPoints where mobile_phone =:mobilenumber";
                updateUserPointsCMD.CommandType = CommandType.Text;
                updateUserPointsCMD.Parameters.Add("newCustomerPoints", updatedCustomerPoints);
                updateUserPointsCMD.Parameters.Add("mobilenumber", CustomerPhoneNumberTextBox.Text);
                updateUserPointsCMD.ExecuteNonQuery();
                MessageBox.Show("Customer Points are " + updatedCustomerPoints.ToString() + " points now.", "Customer's Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Customer_previous_points_textbox.Text = updatedCustomerPoints.ToString();
                conn.Close();
            }

            else
            {
                if (CustomerPhoneNumberTextBox.Text.Count() == 11)
                {

                    updatedCustomerPoints = customerPreviousPoints + currentTransactionPoints;
                    updateUserPointsCMD.CommandText = "update customers set points = :newCustomerPoints where mobile_phone =:mobilenumber";
                    updateUserPointsCMD.CommandType = CommandType.Text;
                    updateUserPointsCMD.Parameters.Add("newCustomerPoints", updatedCustomerPoints);
                    updateUserPointsCMD.Parameters.Add("mobilenumber", CustomerPhoneNumberTextBox.Text);
                    updateUserPointsCMD.ExecuteNonQuery();
                    MessageBox.Show("Customer Points are " + updatedCustomerPoints.ToString() + " points now.", "Customer's Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Customer_previous_points_textbox.Text = updatedCustomerPoints.ToString();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Enter a valid phone number");
                }
            }
        }

        private double DisplayCustomerPreviousPointsAndTotal(string mobileNumber, double totalPrice)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand getPointsCMD = new OracleCommand();
            OracleCommand checkMobileNumberCmd = new OracleCommand();
            OracleCommand insertCustomerCMD = new OracleCommand();
            getPointsCMD.Connection = conn;
            insertCustomerCMD.Connection = conn;
            checkMobileNumberCmd.Connection = conn;
            int count = 0;

            if (mobileNumber.Length == 11)
            {
                checkMobileNumberCmd.CommandText = "CheckCustomerExistance";
                checkMobileNumberCmd.CommandType = CommandType.StoredProcedure;
                checkMobileNumberCmd.Parameters.Add("mobileNumber", mobileNumber);
                checkMobileNumberCmd.Parameters.Add("rowCount", OracleDbType.Int32, ParameterDirection.Output);
                checkMobileNumberCmd.ExecuteNonQuery();
                count = Convert.ToInt32(checkMobileNumberCmd.Parameters["rowCount"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Please Enter 11 Digits for the Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double customerPoints = 0;
            double totalToBeDisplayed;

            if (count > 0)
            {

                getPointsCMD.CommandText = "GetCustomerPoints";
                getPointsCMD.CommandType = CommandType.StoredProcedure;
                getPointsCMD.Parameters.Add("mobileNumber", mobileNumber);
                getPointsCMD.Parameters.Add("customerPoints", OracleDbType.Int32, ParameterDirection.Output);
                getPointsCMD.ExecuteNonQuery();
                Customer_previous_points_textbox.Text = getPointsCMD.Parameters["customerPoints"].Value.ToString();
                customerPoints = Convert.ToDouble(getPointsCMD.Parameters["customerPoints"].Value.ToString());
                if (totalPrice < customerPoints)
                {

                }
                //totalToBeDisplayed = totalPrice - customerPoints;
                if (customerPoints > totalPrice)
                {
                    TotalPaymentWithPointsTextBox.Text = "0";
                }
                else
                {
                    totalToBeDisplayed = totalPrice - customerPoints;
                    TotalPaymentWithPointsTextBox.Text = totalToBeDisplayed.ToString();
                }

                conn.Close();
            }
            else
            {
                if (mobileNumber.Length == 11)
                {
                    int initialPoints = 0;
                    insertCustomerCMD.CommandText = "insert into customers (mobile_phone , points) values(:mobilenumber, :customerpoints)";
                    insertCustomerCMD.CommandType = CommandType.Text;
                    insertCustomerCMD.Parameters.Add("mobilenumber", mobileNumber);
                    insertCustomerCMD.Parameters.Add("customerpoints", initialPoints);
                    int r = insertCustomerCMD.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("A New Customer is Added", "Cashier Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Customer_previous_points_textbox.Text = initialPoints.ToString();
                    customerPoints = initialPoints;
                    //if(customerPoints > )
                    totalToBeDisplayed = totalPrice - customerPoints;
                    TotalPaymentWithPointsTextBox.Text = totalToBeDisplayed.ToString();
                    conn.Close();
                }
            }
            return customerPoints;
        }

        private void DisplayTotalButton_Click(object sender, EventArgs e)
        {
            string mobileNumber = CustomerPhoneNumberTextBox.Text;
            double totalPrice = 0;
            foreach (DataGridViewRow row in TransactionData.Rows)
            {
                totalPrice += Convert.ToDouble(row.Cells[4].Value);
            }
            double customerPreviousPoints = DisplayCustomerPreviousPointsAndTotal(mobileNumber, totalPrice);
            TotalPaymentWithoutPointsTextBox.Text = totalPrice.ToString();
        }

        private void CustomerPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is not a digit and not a control character (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit or a control character, handle the event and suppress the character
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome_form form = (Welcome_form)Program.formStack.Pop();
            form.Show();
        }
    }
}
