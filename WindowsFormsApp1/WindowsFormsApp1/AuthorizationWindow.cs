using MySql.Data.MySqlClient; //для работы клиента с сервером
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AuthorizationWindow : Form
    {
        DB db = new DB();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

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
            String userPassword = PasswordInput_textBox.Text;
            String userLogin = login_textBox.Text;
            /*
             * ничего не делает, если: 
             *      1)поле после попытки ввода пароля осталось пустым (мигающий курсор в нём, но оно пустое; будет красная надпись)
             *      2)попытки ввода пароля не было (есть серая надпись "Введите пароль", она только сразу после запуска программы такая)
            */
            if (PasswordInput_textBox.Text != "" && PasswordInput_textBox.Text != "Введите пароль")
            {          
                //DB db = new DB();

                //DataTable table = new DataTable();

                //MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ln AND `password` = @pswd", db.getConnection());

                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = userLogin;
                command.Parameters.Add("@pswd", MySqlDbType.VarChar).Value = userPassword;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                
                
                //если пароль введён правильно, это окно больше не нужно. поэтому оно закроется и откроет основное
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("HURRAY!");

                    this.Hide();// убираем окно регистрации

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();// открываем основное окно                  
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
    }
}
