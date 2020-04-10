using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string query = "INSERT INTO valami (nev, ido) VALUES('John Smith', '33')";
            string cn = "server=localhost;port=3306;user=root;password=;database=TESZT;SslMode=none";
            MySqlConnection connection = new MySqlConnection(cn);
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                Console.WriteLine("Csatlakozva");
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message + cn);
            }
            Console.ReadKey();
        }
    }
}
