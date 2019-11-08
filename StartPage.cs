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

namespace JointAngle_combine
{
    public partial class StartPage_UI : Form
    {
        string userID = "";
        string userPW = "";

        string dbServer, dbName, dbUid, dbPwd, dbSslMode;
        string DB_INFO;

        MySqlConnection conn;

        private void Database_set()
        {
            dbServer = "localhost";
            dbName = "USER_INFO";
            dbUid = "devLupin";
            dbPwd = "lht1080";
            dbSslMode = "none";

            DB_INFO = "Data Source=" + dbServer + ";" + "Database=" + dbName + ";" + "User Id=" + dbUid + ";" + "Password=" + dbPwd + ";charset=euckr";
        }

        public StartPage_UI()
        {
            InitializeComponent();
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            Join join = new Join();
            join.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (member_radio.Checked)
            {
                // id, pw Validation check
                bool chk = false;

                Database_set();
                try
                {
                    using (conn = new MySqlConnection(DB_INFO))
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }

                        string sql = "SELECT * FROM INFO";      // All data of INFO table.

                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            // ID and P/W of INFO table check
                            if (rdr["ID"].Equals(id_txt.Text) && rdr["PW"].Equals(pw_txt.Text))
                            {
                                chk = true;     // Success is next layout.
                                break;
                            }
                        }
                        rdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT * FROM INFO error!");

                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                if (chk)
                {
                    AngleInfo_user user = new AngleInfo_user(id_txt.Text, pw_txt.Text);
                    user.Show();
                }
                else MessageBox.Show("아이디 또는 비밀번호를 확인해주세요!");
            }
            else if (admin_radio.Checked)
            {
                if(id_txt.Text.Equals("admin") && pw_txt.Text.Equals("gstc4900"))
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호를 확인하세요.");
                }
            }
        }
    }
}
