using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
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

    static void Main()
    {

        string password = Console.ReadLine();
        string hashedPassword = HashPassword(password);
        Console.WriteLine("Hashed password: " + hashedPassword);
    }
}
