using System;
using System.Data.Odbc;
//work with
//System.Data.Odbc 4.7.0-preview3.19551.4

namespace ConsoleODBCDotNetCore3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString = null;
            // Replace the path
            connetionString = @"Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:\Temp\Database3.accdb";
            using OdbcConnection cnn = new OdbcConnection(connetionString);
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
