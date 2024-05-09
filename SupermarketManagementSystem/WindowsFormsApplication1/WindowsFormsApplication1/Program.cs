using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    static class Program
    {
        public static Stack<Form> formStack = new Stack<Form>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // Application.Run(new Finilizing_customer_payment_form());
           // Application.Run(new FormOrderProducts());
           // Application.Run(new FormControlPrices());
            //Application.Run(new FormManageExpiredProducts());
            Application.Run(new Welcome_form());
           
            //Application.Run(new FormGradingEmployees());
        }
    }
    /*static string HashPassword(string password)
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
    }*/
}
