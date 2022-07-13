using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace asd
{
    class DBd
    {
        MySqlConnection connectionn = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=littlebrother");

        //метод для открытия соединения
        public void openConnection()
        {
            if (connectionn.State == System.Data.ConnectionState.Closed)
            {
                connectionn.Open();
            }
        }

        //метод для зарытия соединения
        public void closeConnection()
        {
            if (connectionn.State == System.Data.ConnectionState.Open)
            {
                connectionn.Close();
            }
        }

        //возвращает переменную в инфой о БД
        public MySqlConnection getConnection()
        {
            return connectionn;
        }
    }
}
