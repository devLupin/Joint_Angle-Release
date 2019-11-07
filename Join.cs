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
    public partial class Join : Form
    {
        string dbServer, dbName, dbUid, dbPwd, dbSslMode;
        string DB_INFO;

        MySqlConnection conn;

        public Join()
        {
            InitializeComponent();
        }

        private void Database_set()
        {
            dbServer = "localhost";
            dbName = "USER_INFO";
            dbUid = "devLupin";
            dbPwd = "lht1080";
            dbSslMode = "none";

            DB_INFO = "Data Source=" + dbServer + ";" + "Database=" + dbName + ";" + "User Id=" + dbUid + ";" + "Password=" + dbPwd + ";charset=euckr";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Database_set();

                using (conn = new MySqlConnection(DB_INFO))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                }

                // Check the radio button.
                string sex = "";
                if (sex_man.Checked == true)
                    sex = "M";
                else
                    sex = "W";

                // Sign up info query
                string sql = "INSERT INTO INFO VALUES(" + "'" + name_txt.Text + "'," + "'" + id_txt.Text + "'," + "'" + pw_txt.Text + "'," + "'" + age_txt.Text + "'" + ", '" + sex + "')";
                Console.WriteLine(sql);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원가입 완료!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("INSERT INTO INFO VALUES error!");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }


            this.Dispose();
            conn.Close();
        }
    }
}
