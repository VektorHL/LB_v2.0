using System;
using MySql.Data.MySqlClient; //для работы клиента с сервером
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
//using System.Security.Permissions;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            DBd dbd = new DBd();

            DataTable tablet = new DataTable();

            MySqlDataAdapter adaptert = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = 123 AND `password` = 123", dbd.getConnection());

            adaptert.SelectCommand = command;
            adaptert.Fill(tablet);

            Console.WriteLine("Hello World!");
        }
    }
}
