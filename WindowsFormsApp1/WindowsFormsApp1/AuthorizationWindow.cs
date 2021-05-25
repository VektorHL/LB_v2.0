using MySql.Data.MySqlClient; //для работы клиента с сервером
using Npgsql;
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
using System.Windows.Forms;
using WindowsFormsApp1;
using System.Runtime.Serialization.Formatters.Binary;
using Objects;
using System.Threading;

namespace Client
{
    public partial class AuthorizationWindow : Form
    {
        DB db = new DB();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        private BinaryFormatter _bFormatter;
        private int _port;
        private TcpClient _tcpClient;
        private Thread _listenThread;
        private bool _running;

        //System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        //конструктор для окна авторизации
        public AuthorizationWindow()
        {
            InitializeComponent();

            login_textBox.Text = "login";
            PasswordInput_textBox.Text = "password";
            

            login_textBox.ForeColor = Color.Gray;
            PasswordInput_textBox.ForeColor = Color.Gray;

            //скрывает символы пароля
            this.PasswordInput_textBox.UseSystemPasswordChar = true;

            //clientSocket.Connect("127.0.0.1", 8888);


        }

        private void AuthorizationWindow_Load(object sender, EventArgs e)
        {

        }

        //надпись "Введите пароль для использования". ХЗ почему оно с пометкой КЛИК создалось
        private void PasswordInput_Label_Click(object sender, EventArgs e)
        {

        }

        //поле для ввода пароля
        private void PasswordInput_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        //кнопка "ОК" для отправки пароля на проверку. Действие после клика на неё
        private void Password_OK_Botton_Click(object sender, EventArgs e)
        {
            MessageData md = new MessageData();
            md.M_OperationType = "Authorization";
            md.M_login = "123";
            md.M_password = "123";

            //_bFormatter.Serialize(stream, md);


            String userLogin = login_textBox.Text;
            String userPassword = PasswordInput_textBox.Text;

            //userName = Console.ReadLine();



            //client = new TcpClient();
            //try
            //{
            //    client.Connect(host, port); //подключение клиента
            //    stream = client.GetStream(); // получаем поток

            //    string message = userName;
            //    byte[] data = Encoding.Unicode.GetBytes(message);
            //    stream.Write(data, 0, data.Length);

            //    // запускаем новый поток для получения данных
            //    Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            //    receiveThread.Start(); //старт потока
            //    //Console.WriteLine("Добро пожаловать, {0}", userName);
            //    SendMessage();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Disconnect();
            //}




            /*
             * ничего не делает, если: 
             *      1)поле после попытки ввода пароля осталось пустым (мигающий курсор в нём, но оно пустое; будет красная надпись)
             *      2)попытки ввода пароля не было (есть серая надпись "Введите пароль", она только сразу после запуска программы такая)
            */
            if (PasswordInput_textBox.Text != "" && PasswordInput_textBox.Text != "Введите пароль" && PasswordInput_textBox.Text != "")
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ln AND `password` = @pswd", db.getConnection());

                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = userLogin;
                command.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = userPassword;

                adapter.SelectCommand = command;
                adapter.Fill(table);




                //если пароль введён правильно, это окно больше не нужно. поэтому оно закроется и откроет основное
                if (table.Rows.Count > 0)
                {
                    ////MessageBox.Show("HURRAY!");

                    //this.Hide();// убираем окно регистрации

                    //MainWindow mainWindow = new MainWindow();
                    //mainWindow.Show();// открываем основное окно
                    table = new DataTable();

                    MessageBox.Show("It works!!");
                }
                else
                {
                    MessageBox.Show("Неверный пароль.");
                }
            }
        }


        //по нажатию на поле первый раз после запуска программы, очищает его
        private void PasswordInput_textBox_Enter(object sender, EventArgs e)
        {
            if(PasswordInput_textBox.Text == "password")
            {
                PasswordInput_textBox.Text = "";
                PasswordInput_textBox.ForeColor = Color.Black;
            }

        }
        
        //если поле пустое
        private void PasswordInput_textBox_Leave(object sender, EventArgs e)
        {
            if (PasswordInput_textBox.Text == "")
            {
                PasswordInput_textBox.Text = "password";
                PasswordInput_textBox.ForeColor = Color.Red;
            }
        }



        private void login_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_textBox_Enter(object sender, EventArgs e)
        {
            if (login_textBox.Text == "login")
            {
                login_textBox.Text = "";
                login_textBox.ForeColor = Color.Black;
            }
        }

        private void login_textBox_Leave(object sender, EventArgs e)
        {
            if (login_textBox.Text == "")
            {
                login_textBox.Text = "login";
                login_textBox.ForeColor = Color.Red;
            }
        }




        static void SendMessage()
        {
            //Console.WriteLine("Введите сообщение: ");

            while (true)
            {
                string message = Console.ReadLine();
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
        }
        // получение сообщений
        static void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    Console.WriteLine(message);//вывод сообщения
                }
                catch
                {
                    Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    Console.ReadLine();
                    Disconnect();
                }
            }
        }

        static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }




    }
}
