using System;
using System.Data.OleDb;

namespace ConsoleOleDBDotNetCore3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            // Replace the path
            connetionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Jmf-msi\dev298\DEV Databases_BSF\Database1.accdb;Jet OLEDB:Database Password=password";
            using OleDbConnection cnn = new OleDbConnection(connetionString);
            try
            {

                cnn.Open();

                Console.WriteLine("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
        }
    }
}
