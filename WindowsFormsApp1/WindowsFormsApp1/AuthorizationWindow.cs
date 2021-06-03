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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Objects;
using System.Threading;
using System.IO;

namespace Client
{
    public partial class AuthorizationWindow : Form
    {
        DB db = new DB();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();



        //static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;

        public static TcpClient clientSocket = new TcpClient(host, port);
        NetworkStream serverStream = clientSocket.GetStream();

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

        }

        private void AuthorizationWindow_Load(object sender, EventArgs e)
        {
            //clientSocket.Connect("127.0.0.1", 8888);
            msg("Client Socket Program - Server Connected ...");
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
            md.M_login = login_textBox.Text;
            md.M_password = PasswordInput_textBox.Text;

            //_bFormatter.Serialize(stream, md);


            String userLogin = login_textBox.Text;
            String userPassword = PasswordInput_textBox.Text;        

            serverStream = clientSocket.GetStream();

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(serverStream, md);

            string answer = (string)formatter.Deserialize(serverStream);



            /*
             * ничего не делает, если: 
             *      1)поле после попытки ввода пароля осталось пустым (мигающий курсор в нём, но оно пустое; будет красная надпись)
             *      2)попытки ввода пароля не было (есть серая надпись "Введите пароль", она только сразу после запуска программы такая)
            */
            if (PasswordInput_textBox.Text != "" && PasswordInput_textBox.Text != "Введите пароль" && PasswordInput_textBox.Text != "")
            {
                //если пароль введён правильно, это окно больше не нужно. поэтому оно закроется и откроет основное
                if (answer == "yes")
                {
   
                    //table = new DataTable();

                    MessageBox.Show("It works!!");
                }
                else
                {
                    MessageBox.Show("Неверный пароль.");
                }
            }
            //serverStream.Close();
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



        public void msg(string mesg)
        {
            MessageBox.Show(mesg);
        }

        private void AuthorizationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serverStream.Close();
            //clientSocket.Close();
        }

        private void AuthorizationWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //serverStream.Close();
            //clientSocket.Close();
        }

        //public BinaryFormatter getSerializedMessage (NetworkStream stream, BinaryFormatter BF, MessageData MD)
        //{
        //    //BinaryFormatter binFmr = new BinaryFormatter();
        //    //MessageData messageData = new MessageData();
        //    int buf;

        //    BF.Serialize(stream, MD);
        //    return BF;

        //    //binFmr.Serialize(stream, this.messageData);
        //}

        //networkStream.Close();
        //clientSocket.Close();
    }
}
