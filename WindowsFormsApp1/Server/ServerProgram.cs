using MySql.Data.MySqlClient; //для работы клиента с сервером
//using Npgsql;
using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Runtime.Serialization.Formatters.Binary;
using Objects;
using System.Threading;
using System.Security.Permissions;
using Client;

namespace Server
{
    class ServerProgram
    {
        //static ServerObject server; // сервер
        //static Thread listenThread; // потока для прослушивания

        static void Main(string[] args)
        {

            //serverDB dB = new serverDB();

            DB db = new DB();

            DataTable dataTable = new DataTable();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            //try
            //{
            //    server = new ServerObject();
            //    listenThread = new Thread(new ThreadStart(server.Listen));
            //    listenThread.Start(); //старт потока
            //}
            //catch (Exception ex)
            //{
            //    server.Disconnect();
            //    Console.WriteLine(ex.Message);
            //}

            Console.WriteLine("asd");

            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ln AND `password` = @pswd", db.getConnection());

            MySqlCommand command = new MySqlCommand("SELECT id FROM `users`", db.getConnection());

            //command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = userLogin;
            //command.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = userPassword;


            adapter.SelectCommand = command;

            Console.WriteLine("asd");
            table = new DataTable();

            adapter.Fill(table);

            Console.WriteLine("asd");

            if (table.Rows.Count > 0)
            {
                ////MessageBox.Show("HURRAY!");

                //this.Hide();// убираем окно регистрации

                //MainWindow mainWindow = new MainWindow();
                //mainWindow.Show();// открываем основное окно

                Console.WriteLine("asd");
            }
            else
            {
                Console.WriteLine("assd");
            }

        }
    }



    
}


//System.IO.FileNotFoundException: 'Could not load file or assembly 'System.Security.Permissions, Version = 0.0.0.0, Culture = neutral, PublicKeyToken = cc7b13ffcd2ddd51'. 
//    Не удается найти указанный файл.'
