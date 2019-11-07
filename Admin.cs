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

using Microsoft.Speech;
using Microsoft.Speech.Synthesis;
using System.Diagnostics;

namespace JointAngle_combine
{
    public partial class Admin : Form
    {
        string dbServer, dbName, dbUid, dbPwd, dbSslMode;
        string DB_INFO;

        MySqlConnection conn;

        private void userResult_btn_Click(object sender, EventArgs e)
        {
            AngleInfo_user user = new AngleInfo_user(id_txt.Text);
            user.Show();
        }

        string userID;

        //Set the database info
        private void Database_set()
        {
            dbServer = "localhost";
            dbName = "USER_INFO";
            dbUid = "devLupin";
            dbPwd = "lht1080";
            dbSslMode = "none";

            DB_INFO = "Data Source=" + dbServer + ";" + "Database=" + dbName + ";" + "User Id=" + dbUid + ";" + "Password=" + dbPwd + ";charset=euckr";
        }

        public Admin()
        {
            InitializeComponent();
        }

        private void measureStart_btn_Click(object sender, EventArgs e)
        {
            bool chk = false;

            string argv = "";
            if (set1_radio.Checked) argv = "SET1";
            else if (set2_radio.Checked) argv = "SET2";
            else if (set3_radio.Checked) argv = "SET3";
            else if (set4_radio.Checked) argv = "SET4";
            else if (set5_radio.Checked) argv = "SET5";

            Database_set();

            using (conn = new MySqlConnection(DB_INFO))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //MessageBox.Show("Server connected");
                try
                {
                    chk = false;

                    string sql = "SELECT * FROM INFO WHERE ID=" + "'" + id_txt.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        if (rdr["ID"].ToString().Equals(id_txt.Text))
                        {
                            chk = true;
                            this.userID = id_txt.Text;
                            break;
                        }
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT * FROM INFO WHERE ID= error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }
            conn.Close();

            if (chk)
            {
                SpeechSynthesizer ts = new SpeechSynthesizer();
                ts.SelectVoice("Microsoft Server Speech Text to Speech Voice (ko-KR, Heami)");
                ts.SetOutputToDefaultAudioDevice();
                ts.Speak(argv + "의 측정을 시작합니다!");

                // Mesure program start 
                string path = @"C:\Users\devLupin\NuitrackSDK\Examples\csharp_test\build\nuitrack_csharp_sample.exe";
                string argument = this.userID + " " + argv;

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = argument
                };
                Process process = Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("존재하지 않는 아이디 입니다!");
            }
        }
    }
}
