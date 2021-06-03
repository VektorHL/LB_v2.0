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
using System.Runtime.Serialization;
using System.IO;

namespace Server
{
    class ServerProgram
    {
        static void Main(string[] args)
        {
            DB db = new DB();

            DataTable dataTable = new DataTable();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            
            TcpListener server = new TcpListener(8888);
            server.Start();
            Console.WriteLine("Сервер запущен. Джём клиента");
            TcpClient client = server.AcceptTcpClient();
            NetworkStream strm = client.GetStream();
            Console.WriteLine("Клиент подключился");

            while (true)
            {
                if(!client.Connected)
                {
                    Console.WriteLine("Соединение с клиентом потеряно. Перезапускаю сервак и ожидаю клиента");
                    client.Close();
                    server.Stop();

                    server = new TcpListener(8888);
                    server.Start();
                    client = server.AcceptTcpClient();
                    strm = client.GetStream();
                    Console.WriteLine("Клиент подключился");
                }

                try
                {
                    strm = client.GetStream();
                    IFormatter formatter = new BinaryFormatter();
                    MessageData message = (MessageData)formatter.Deserialize(strm);
                    string login = message.M_login;

                    switch (message.M_OperationType) 
                    {
                        case "Authorization":
                            Console.WriteLine("oper type - Authorization");

                            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ln AND `password` = @pswd", db.getConnection());

                            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = message.M_login;
                            cmd.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = message.M_password;

                            adapter.SelectCommand = cmd;
                            table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                table = new DataTable();

                                string answer = "yes";
                                formatter.Serialize(strm, answer);

                                Console.WriteLine("Авторизация удалась");
                            }
                            else
                            {
                                table = new DataTable();
                                string answer = "no";
                                formatter.Serialize(strm, answer);

                                Console.WriteLine("Неверный логин или пароль");
                            }
                            break;
                        
                        case "Add Movement":
                            Console.WriteLine("oper type - Add Movement");
                            //List<string[]> data = new List<string[]>();
                            
                            //if (IsClientConnected(client))
                            //{
                            //    SetDataForAnswer(message, data);
                            //}
                            //formatter.Serialize(strm, data);

                            break;

                        case "Get Memb Way":
                            Console.WriteLine("oper type - Get Memb Way");
                            //List<string[]> data = new List<string[]>();

                            //if (IsClientConnected(client))
                            //{
                            //    SetDataForAnswer(message, data);
                            //}
                            //formatter.Serialize(strm, data);

                            break;

                        case "Get Overtime Stat":
                            Console.WriteLine("oper type - Get Overtime Stat");
                            //List<string[]> data = new List<string[]>();

                            //if (IsClientConnected(client))
                            //{
                            //    SetDataForAnswer(message, data);
                            //}
                            //formatter.Serialize(strm, data);

                            break;

                        case "Get Room Stat":
                            Console.WriteLine("oper type - Get Room Stat");
                            //List<string[]> data = new List<string[]>();

                            //if (IsClientConnected(client))
                            //{
                            //    SetDataForAnswer(message, data);
                            //}
                            //formatter.Serialize(strm, data);

                            break;

                    }
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }

 
}
