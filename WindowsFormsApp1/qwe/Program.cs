using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qwe
{
    class Program
    {
        static void Main(string[] args)
        {
            asdasd asdd = new asdasd();

            DataTable tablet = new DataTable();

            MySqlDataAdapter adaptert = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", asdd.getConnection());

            adaptert.SelectCommand = command;
            adaptert.Fill(tablet);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
