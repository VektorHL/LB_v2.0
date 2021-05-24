using MySql.Data.MySqlClient; //нужно для подключения к БД
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DB
    {
        //переменная с данными о серваке и БД
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=littlebrother");

        //метод для открытия соединения
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
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
