using MySql.Data.MySqlClient;
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
    public partial class MemberWayWindow : Form
    {
        DB db = new DB();

        string _memberName;
        //string _room;

        //DataTable table = new DataTable();

        public MemberWayWindow(string member/*, string room*/)
        {
            _memberName = member;
            //_room = room;
            
            InitializeComponent();
            LoadDataTaining();
        }

        private void LoadDataTaining()
        {
            //throw new NotImplementedException();

            string connection = "server=localhost; port=3306; username=root; password=root; database=littlebrother";

            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();

            string query = "SELECT DATE_FORMAT(`date`, '%d.%m.%Y') AS date, " +
                                "(SELECT CONCAT(`fName`, ' ', `sName`, ' ', `tName`) FROM `members` " +
                                    "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + _memberName + "') AS name, " +
                                "(SELECT `room` FROM `rooms` WHERE rooms.id = st.room_id) AS room, " +
                                "`time_in`, `time_out`, " +
                                "TIMEDIFF(`time_out`, `time_in`) AS duration " +
                            "FROM `st` " +
                            "INNER JOIN `members` AS m " +
                            "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + _memberName + "' " +
                            "AND st.member_id = m.id " +
                            "AND `time_out` IS NOT NULL " +
                            "AND st.date = CURRENT_DATE() - 7";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            //db.openConnection();

            MySqlDataReader reader = cmd.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            mySqlConnection.Close();

            dataGridView.Rows.Clear();
            foreach (string[] row in data)
            {
                dataGridView.Rows.Add(row);
            }
        }
    }
}
