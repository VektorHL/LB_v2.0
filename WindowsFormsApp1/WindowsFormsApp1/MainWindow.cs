using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        DB db = new DB();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        //это я прописал и потом принудительно поиндексно присвоил чисто ради удобства
        String[] movesType_comboBox_Collection = new String[] { "Маршрут сотрудника",
                                                                "Пребывание сотрудника в зонах",
                                                                "Переработка" };

        public MainWindow()
        {
            InitializeComponent();

            getMoves_movesType_comboBox.Text = "Вид отчёта";

            names_comboBox.Text = "ФИО";
            getMoves_names_comboBox.Text = "ФИО";
            //names_comboBox.ForeColor = Color.Gray;

            rooms_comboBox.Text = "Помещение";
            //getMoves_rooms_comboBox.Text = "Помещение";
            //rooms_comboBox.ForeColor = Color.Gray;

            //команда для получения списка помещений
            MySqlCommand cmd = new MySqlCommand("SELECT `room` FROM `rooms`", db.getConnection());

            db.openConnection();//открываем соединение, чтобы контачить с БД

            DbDataReader dataReader = cmd.ExecuteReader();//создаём ридер, чтоб он читал поток строк от команды 

            while (dataReader.Read())//читаем построчно, пока строки есть
            {
                //добавляем значения из БД в список comboBox -ов
                rooms_comboBox.Items.Add(dataReader["room"].ToString());
                //getMoves_rooms_comboBox.Items.Add(dataReader["room"].ToString());
            }

            db.closeConnection();//закрываем соединение
            db.openConnection();//открываем новое для нового запроса

            cmd = new MySqlCommand("SELECT CONCAT(`fName`, ' ', `sName`, ' ', `tName`) AS fullName FROM `members`", db.getConnection());
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                names_comboBox.Items.Add(dataReader["fullName"].ToString());
                getMoves_names_comboBox.Items.Add(dataReader["fullName"].ToString());
            }

            dataReader.Close();
            db.closeConnection();

            for (int i = 0; i < movesType_comboBox_Collection.Length; i++)
            {
                getMoves_movesType_comboBox.Items[i] = movesType_comboBox_Collection[i];
            }
        }


        //таблица для удобства вёрстки
        private void MainWindow_tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //
        private void moves_label_Click(object sender, EventArgs e)
        {

        }


        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void getMoves_movesType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (getMoves_movesType_comboBox.Text)
            {
                case "Маршрут сотрудника":

                    getMoves_names_comboBox.Text = "Выберите ФИО сотрудника";

                    break;
                case "Пребывание сотрудника в зонах":

                    getMoves_names_comboBox.Text = "ФИО сотрудника";

                    break;
                case "Переработка":

                    getMoves_names_comboBox.Text = "Выберите ФИО";

                    break;
            }
        }

        private void getMoves_button_Click(object sender, EventArgs e)
        {
            switch (getMoves_movesType_comboBox.Text)
            {
                case "Маршрут сотрудника":

                    MemberWayWindow memWayWindow = new MemberWayWindow(getMoves_names_comboBox.Text/*, getMoves_rooms_comboBox.Text*/);
                    memWayWindow.Show();

                    break;
                case "Пребывание сотрудника в зонах":

                    RoomStatWindow roomStatWindow = new RoomStatWindow(getMoves_names_comboBox.Text/*, getMoves_rooms_comboBox.Text*/);
                    roomStatWindow.Show();

                    break;
                case "Переработка":

                    OvertimeWindow overtimeWindow = new OvertimeWindow(getMoves_names_comboBox.Text/*, getMoves_rooms_comboBox.Text*/);
                    overtimeWindow.Show();

                    break;
            }
        }

        private void getMoves_rooms_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void names_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rooms_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IN_button_Click(object sender, EventArgs e)
        {
            String update = "UPDATE `st` SET `time_out` = CURRENT_TIME() WHERE `member_id` = " +
                                "(SELECT id FROM `members` WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + names_comboBox.Text + "') ORDER BY `id` DESC LIMIT 1; ";

            String insert = "INSERT INTO `st` (`id`, `member_id`, `room_id`, `date`, `time_in`, `time_out`) VALUES" + "(NULL, ";

            //подзапросы для главного запроса. получают id выбранного в окне работника и помещения соответственно
            String memberIdGet = "(SELECT id FROM `members` WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + names_comboBox.Text + "'), ";
            String roomIdGet = "(SELECT id FROM `rooms` WHERE `room` = '" + rooms_comboBox.Text + "'), CURRENT_DATE(), CURRENT_TIME(), NULL)";


            db.openConnection();

            try
            {
                //запрос для вставки нового передвижения
                MySqlCommand cmd = new MySqlCommand(update + insert + memberIdGet + roomIdGet, db.getConnection());
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка! Запись не будет добавлена!");
            }
            finally { }

            db.closeConnection();
        }
    }
}
