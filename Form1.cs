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


namespace SupermarketManagementSystem
{


    public partial class FinalizePaymentForm : Form
    {
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";

        OracleConnection conn;
        
        public FinalizePaymentForm()
        {
            InitializeComponent();
        }

        private void FinalizeBtn_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            double totalPrice = Convert.ToDouble(TotalPriceTextBox.Text);

            OracleCommand selectMaxCMD = new OracleCommand();
            selectMaxCMD.Connection = conn;
            selectMaxCMD.CommandText = "SELECT MAX(TRANSACTION_ID) FROM transactions";
            selectMaxCMD.CommandType = CommandType.Text;
            object result = selectMaxCMD.ExecuteScalar();

            OracleCommand insertTransactionCMD = new OracleCommand();
            insertTransactionCMD.Connection = conn;

            double customerPreviousPoints = Convert.ToDouble(PreviousPointsTextBox.Text);

            
            if (FinWithPointsRBtn.Checked)
            {
                double totalPriceWithPoints = Convert.ToDouble(TotalPriceWithPointsTestBox.Text);
                insertTransactionCMD.CommandText = "insert into transactions values( :transID ,:totalPrice)";
                insertTransactionCMD.CommandType = CommandType.Text;
                int newID = Convert.ToInt32(result.ToString()) + 1;
                insertTransactionCMD.Parameters.Add("transID", newID);
                insertTransactionCMD.Parameters.Add("totalPrice", totalPriceWithPoints);
                insertTransactionCMD.ExecuteNonQuery();
                UpdateUserPoints(true, totalPrice, customerPreviousPoints);

            }
            else if (FinWithoutPointsRBtn.Checked)
            {
                
                insertTransactionCMD.CommandText = "insert into transactions values(:transID , :totalPrice)";
                insertTransactionCMD.CommandType = CommandType.Text;
                int newID = Convert.ToInt32(result.ToString()) + 1;
                insertTransactionCMD.Parameters.Add("transID", newID);
                insertTransactionCMD.Parameters.Add("totalPrice", totalPrice);
                insertTransactionCMD.ExecuteNonQuery();
                UpdateUserPoints(false, totalPrice, customerPreviousPoints);

            }
            
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void CalcTotalBtn_Click(object sender, EventArgs e)
        {
            string mobileNumber = PhoneNumberTextBox.Text;
            double totalPrice = 0;
            foreach(DataGridViewRow row in TransactionData.Rows)
            {
                totalPrice += Convert.ToDouble(row.Cells[4].Value);
            }
            double customerPreviousPoints = DisplayCustomerPreviousPointsAndTotal(mobileNumber, totalPrice);
            TotalPriceTextBox.Text = totalPrice.ToString();
            CalcTotalBtn.Hide();
            FinalizeBtn.Show();
            
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
                updateUserPointsCMD.Parameters.Add("mobilenumber", PhoneNumberTextBox.Text);
                updateUserPointsCMD.ExecuteNonQuery();
                MessageBox.Show("Customer Points are " + updatedCustomerPoints.ToString() + " points now.", "Customer's Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PreviousPointsTextBox.Text = updatedCustomerPoints.ToString();
                conn.Close();
            }

            else
            {
                
                updatedCustomerPoints = customerPreviousPoints + currentTransactionPoints;
                updateUserPointsCMD.CommandText = "update customers set points = :newCustomerPoints where mobile_phone =:mobilenumber";
                updateUserPointsCMD.CommandType = CommandType.Text;
                updateUserPointsCMD.Parameters.Add("newCustomerPoints", updatedCustomerPoints);
                updateUserPointsCMD.Parameters.Add("mobilenumber", PhoneNumberTextBox.Text);
                updateUserPointsCMD.ExecuteNonQuery();
                MessageBox.Show("Customer Points are " + updatedCustomerPoints.ToString() + " points now.", "Customer's Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PreviousPointsTextBox.Text = updatedCustomerPoints.ToString();
                conn.Close();
            }
        }
       
        private double DisplayCustomerPreviousPointsAndTotal(string mobileNumber,  double totalPrice)
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

            double customerPoints;
            double totalToBeDisplayed;

            if (count > 0) 
            {
                
                getPointsCMD.CommandText = "GetCustomerPoints";
                getPointsCMD.CommandType = CommandType.StoredProcedure;
                getPointsCMD.Parameters.Add("mobileNumber", mobileNumber);
                getPointsCMD.Parameters.Add("customerPoints", OracleDbType.Int32, ParameterDirection.Output);
                getPointsCMD.ExecuteNonQuery();
                PreviousPointsTextBox.Text = getPointsCMD.Parameters["customerPoints"].Value.ToString();
                customerPoints = Convert.ToDouble(getPointsCMD.Parameters["customerPoints"].Value.ToString());
                if(totalPrice < customerPoints)
                {

                }
                //totalToBeDisplayed = totalPrice - customerPoints;
                if (customerPoints > totalPrice)
                {
                    TotalPriceWithPointsTestBox.Text = "0";
                }
                else
                {
                    totalToBeDisplayed = totalPrice - customerPoints;
                    TotalPriceWithPointsTestBox.Text = totalToBeDisplayed.ToString();
                }
                
                conn.Close();
            }
            else 
            {
                
                int initialPoints = 0;
                insertCustomerCMD.CommandText = "insert into customers (mobile_phone , points) values(:mobilenumber, :customerpoints)";
                insertCustomerCMD.CommandType = CommandType.Text;
                insertCustomerCMD.Parameters.Add("mobilenumber", mobileNumber);
                insertCustomerCMD.Parameters.Add("customerpoints", initialPoints);
                int r = insertCustomerCMD.ExecuteNonQuery();
                if(r != -1)
                {
                    MessageBox.Show("A New Customer is Added", "Cashier Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                PreviousPointsTextBox.Text = initialPoints.ToString();
                customerPoints = initialPoints;
                //if(customerPoints > )
                totalToBeDisplayed = totalPrice - customerPoints;
                TotalPriceWithPointsTestBox.Text = totalToBeDisplayed.ToString();
                conn.Close();
            }
            return customerPoints;
        }

        private void CustomerPreviousPoints_Click(object sender, EventArgs e)
        {

        }

        private void FinalizePaymentForm_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select Category_ID,Category_Name from ProductsCategory";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CatergoriesComboBox.Items.Add(dr[1]);
            }
            dr.Close();
            FinalizeBtn.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select Product_Name from Products where Category_ID=:id";
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

        private void AddProductBtn_Click(object sender, EventArgs e)
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

        private void DelProductBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in TransactionData.SelectedRows)
            {
                TransactionData.Rows.RemoveAt(row.Index);
            }
        }
    }
}
