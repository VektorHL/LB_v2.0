using System;
using MySql.Data.MySqlClient; //для работы клиента с сервером
//using Npgsql;
//using System.Net;
//using System.Net.Sockets;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.Drawing;
using WindowsFormsApp1;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Security.Permissions;

namespace Server
{
    class serverDB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=littlebrother");

        //метод для открытия соединения
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //метод для зарытия соединения
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //возвращает переменную в инфой о БД
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
