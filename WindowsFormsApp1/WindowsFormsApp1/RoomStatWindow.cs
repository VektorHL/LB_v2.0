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
    public partial class RoomStatWindow : Form
    {
        //DB db = new DB();

        string _memberName;
        //string _room;

        public RoomStatWindow(string member/*, string room*/)
        {
            _memberName = member;
            //_room = room;

            InitializeComponent();
            LoadDataTaining();
            
            this.Text = _memberName;
        }

        private void LoadDataTaining()
        {
            string connection = "server=localhost; port=3306; username=root; password=root; database=littlebrother";

            MySqlConnection mySqlConnection = new MySqlConnection(connection);
            mySqlConnection.Open();

            string query = "SELECT `room`, SEC_TO_TIME(SUM(duration_inSEC)) AS duration FROM " +
                                "(SELECT (SELECT `room` FROM `rooms` WHERE rooms.id = st.room_id) AS room, " +
                                        "CASE WHEN `time_in` < `time_out` THEN " +
                                            "TIMESTAMPDIFF(second, `time_in`, `time_out`) " +
                                        "ELSE " +
                                            "86400 + TIMESTAMPDIFF(second, `time_in`, `time_out`) END AS duration_inSEC " +
                                "FROM `st`" +
                                "INNER JOIN `members` AS m " +
                                "WHERE CONCAT(`fName`, ' ', `sName`, ' ', `tName`) = '" + _memberName + "' " +
                                "AND st.member_id = m.id " +
                                "AND `time_out` IS NOT NULL " +
                                "AND WEEK(st.date) = WEEK(CURRENT_DATE() -4)) as secc " +
                            "GROUP BY secc.room";

            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
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
