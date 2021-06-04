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
        private static string host = "127.0.0.1";
        private static int port = 8888;

        static void Main(string[] args)
        {
            DB db = new DB();

            DataTable dataTable = new DataTable();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            TcpListener server = new TcpListener(IPAddress.Parse(host), port);
            server.Start();
            Console.WriteLine("Сервер запущен. Ждём клиента");
            TcpClient client = server.AcceptTcpClient();
            NetworkStream strm = client.GetStream();
            Console.WriteLine("Клиент подключился");

            MessageData message = new MessageData();                

            while (true)
            {
                if (!client.Connected)
                {
                    Console.WriteLine("Соединение с клиентом потеряно. Перезапускаю сервак и ожидаю клиента");
                    client.Close();
                    server.Stop();

                    server = new TcpListener(IPAddress.Parse(host), port);
                    server.Start();
                    client = server.AcceptTcpClient();
                }           
                else
                {
                    try
                    {
                        strm = client.GetStream();
                        
                        IFormatter formatter = new BinaryFormatter();
                        message = (MessageData)formatter.Deserialize(strm);

                        MySqlCommand cmd = new MySqlCommand();

                        switch (message.M_OperationType)
                        {
                            //#########################################################################################################################
                            case "Authorization":
                                Console.WriteLine("oper type - Authorization");

                                cmd = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ln AND `password` = @pswd", db.getConnection());

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
                                    client.Close();
                                    server.Stop();
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
                                break;

                            //#########################################################################################################################
                            case "Get Memb Way":
                                Console.WriteLine("oper type - Get Memb Way");
                                string connection1 = "server=localhost; port=3306; username=root; password=root; database=littlebrother";

                                MySqlConnection mySqlConnection1 = new MySqlConnection(connection1);
                                mySqlConnection1.Open();

                                string query1 = "SELECT DATE_FORMAT(`date`, '%d.%m.%Y') AS date, " +
                                                    "(SELECT CONCAT(`fName`, ' ', `sName`, ' ', `tName`) FROM `members` " +
                                                        "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + message.M_memberName + "') AS name, " +
                                                    "(SELECT `room` FROM `rooms` WHERE rooms.id = st.room_id) AS room, " +
                                                    "`time_in`, `time_out`, " +
                                                    "TIMEDIFF(`time_out`, `time_in`) AS duration " +
                                                "FROM `st` " +
                                                "INNER JOIN `members` AS m " +
                                                "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + message.M_memberName + "' " +
                                                "AND st.member_id = m.id " +
                                                "AND `time_out` IS NOT NULL "; //+
                                                                               //"AND st.date = 2021-03-09";

                                MySqlCommand cmd1 = new MySqlCommand(query1, mySqlConnection1);
                                db.openConnection();

                                List<string[]> data1 = new List<string[]>();

                                MySqlDataReader reader1 = cmd1.ExecuteReader();
                                while (reader1.Read())
                                {
                                    data1.Add(new string[6]);

                                    data1[data1.Count - 1][0] = reader1[0].ToString();
                                    data1[data1.Count - 1][1] = reader1[1].ToString();
                                    data1[data1.Count - 1][2] = reader1[2].ToString();
                                    data1[data1.Count - 1][3] = reader1[3].ToString();
                                    data1[data1.Count - 1][4] = reader1[4].ToString();
                                    data1[data1.Count - 1][5] = reader1[5].ToString();
                                }
                                
                                reader1.Close();
                                mySqlConnection1.Close();

                                formatter.Serialize(strm, data1);
         
                                break;

                            //#########################################################################################################################
                            case "Get Overtime Stat":
                                Console.WriteLine("oper type - Get Overtime Stat");
                                string connection2 = "server=localhost; port=3306; username=root; password=root; database=littlebrother";

                                MySqlConnection mySqlConnection2 = new MySqlConnection(connection2);
                                mySqlConnection2.Open();

                                string query2 = "SELECT (SELECT CONCAT(`fName`, ' ', `sName`, ' ', `tName`) FROM `members` " +
                                                            "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + message.M_memberName + "') AS fullName, " +
                                                        "28800/3600 AS plan, " +
                                                        "SUM(duration_inSEC)/3600 AS fact, " +
                                                        "(SUM(duration_inSEC) - 28800)/3600 AS overtime_inSEC FROM " +
                                                    "(SELECT (SELECT `room` FROM `rooms` WHERE rooms.id = st.room_id) AS room, " +
                                                            "CASE WHEN `time_in` < `time_out` THEN " +
                                                                "TIMESTAMPDIFF(second, `time_in`, `time_out`) " +
                                                            "ELSE " +
                                                                "86400 + TIMESTAMPDIFF(second, `time_in`, `time_out`) END AS duration_inSEC " +
                                                    "FROM `st`" +
                                                    "INNER JOIN `members` AS m " +
                                                    "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + message.M_memberName + "' " +
                                                    "AND st.member_id = m.id " +
                                                    "AND `time_out` IS NOT NULL " +
                                                    "AND WEEK(st.date) = WEEK('2021-03-16') ) as secc " +
                                                "GROUP BY `fullName`";

                                MySqlCommand cmd2 = new MySqlCommand(query2, mySqlConnection2);
                                db.openConnection();

                                MySqlDataReader reader2 = cmd2.ExecuteReader();

                                List<string[]> data2 = new List<string[]>();

                                while (reader2.Read())
                                {
                                    data2.Add(new string[4]);

                                    data2[data2.Count - 1][0] = reader2[0].ToString();
                                    data2[data2.Count - 1][1] = reader2[1].ToString();
                                    data2[data2.Count - 1][2] = reader2[2].ToString();
                                    data2[data2.Count - 1][3] = reader2[3].ToString();
                                }

                                reader2.Close();
                                mySqlConnection2.Close();

                                formatter.Serialize(strm, data2);

                                break;

                            //#########################################################################################################################
                            case "Get Room Stat":
                                Console.WriteLine("oper type - Get Room Stat");

                                string connection3 = "server=localhost; port=3306; username=root; password=root; database=littlebrother";

                                MySqlConnection mySqlConnection3 = new MySqlConnection(connection3);
                                mySqlConnection3.Open();

                                string query3 = "SELECT `room`, SEC_TO_TIME(SUM(duration_inSEC)) AS duration FROM " +
                                                    "(SELECT (SELECT `room` FROM `rooms` WHERE rooms.id = st.room_id) AS room, " +
                                                            "CASE WHEN `time_in` < `time_out` THEN " +
                                                                "TIMESTAMPDIFF(second, `time_in`, `time_out`) " +
                                                            "ELSE " +
                                                                "86400 + TIMESTAMPDIFF(second, `time_in`, `time_out`) END AS duration_inSEC " +
                                                    "FROM `st`" +
                                                    "INNER JOIN `members` AS m " +
                                                    "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + message.M_memberName + "' " +
                                                    "AND st.member_id = m.id " +
                                                    "AND `time_out` IS NOT NULL " +
                                                    "AND WEEK(st.date) = WEEK('2021-03-16')) as secc " +
                                                "GROUP BY secc.room";

                                MySqlCommand cmd3 = new MySqlCommand(query3, mySqlConnection3);
                                db.openConnection();

                                MySqlDataReader reader3 = cmd3.ExecuteReader();

                                List<string[]> data3 = new List<string[]>();

                                while (reader3.Read())
                                {
                                    data3.Add(new string[2]);

                                    data3[data3.Count - 1][0] = reader3[0].ToString();
                                    data3[data3.Count - 1][1] = reader3[1].ToString();
                                }

                                reader3.Close();
                                mySqlConnection3.Close();

                                formatter.Serialize(strm, data3);

                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
    }

 
}
