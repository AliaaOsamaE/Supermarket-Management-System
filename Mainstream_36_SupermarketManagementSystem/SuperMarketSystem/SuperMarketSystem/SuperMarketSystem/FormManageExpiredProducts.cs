using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace SuperMarketSystem
{
    public partial class FormManageExpiredProducts : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection conn;
        DataTable dataTable;
        public FormManageExpiredProducts()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }

        private void FormManageExpiredProducts_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            using (OracleCommand cmd = new OracleCommand("GetExpiredData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("expired", OracleDbType.RefCursor, ParameterDirection.Output);

                if (dataTable.Rows.Count > 0)
                    dataTable.Rows.Clear();


                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    dataTable.Load(dr);
                }

                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1.DataSource = dataTable;
                }));
            }

            decimal total_cost = CalculateTotalCost();

            textBox1.Text = total_cost.ToString();
        }

        private decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            conn = new OracleConnection(ordb);
            conn.Open();
            using (OracleCommand cmd = new OracleCommand("CalculateTotalPrice", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("total_price", OracleDbType.Decimal, ParameterDirection.Output);
                cmd.ExecuteNonQuery();

                OracleDecimal oracleDecimal = (OracleDecimal)cmd.Parameters["total_price"].Value;
                if (!oracleDecimal.IsNull)
                {
                    totalCost = oracleDecimal.Value;
                }
            }
            return totalCost;
        }

        private void InsertSumIntoNewTable(decimal total_cost)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Losses (Loss_ID, Total_Loss_Amount, Loss_Date) VALUES (loss_seq.NEXTVAL, :cost, :lossDate)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("cost", OracleDbType.Decimal).Value = total_cost;
            cmd.Parameters.Add("lossDate", OracleDbType.Date).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
        }

        private void UpdateExpiredRows()
        {
            using (OracleCommand cmd = new OracleCommand("UPDATE Products SET Number_Of_Units = 0, Expiary_Date = TO_DATE('01-JAN-0001', 'DD-MON-YYYY') WHERE Expiary_Date < SYSDATE", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void FormManageExpiredProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total_cost = CalculateTotalCost();
            if (total_cost > 0)
            {
                InsertSumIntoNewTable(total_cost);
                UpdateExpiredRows();
                ((DataTable)dataGridView1.DataSource).DefaultView.Table.Rows.Clear();
                dataGridView1.Refresh();
                MessageBox.Show("Expired products reomved successfully.");
            }
            else
            {
                MessageBox.Show("No expired products.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManagerTasks ManagerTasksform = (FormManagerTasks)Program.formStack.Pop();
            ManagerTasksform.Show();
        }
    }
}
