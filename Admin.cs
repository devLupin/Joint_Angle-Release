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
            // IF,, not typing id
            if (id_txt.Text.Length > 1)
            {
                AngleInfo_user user = new AngleInfo_user(id_txt.Text);
                user.Show();
            }
            else
            {
                MessageBox.Show("아이디를 입력해야 합니다!");
            }
        }

        private void detail_btn_Click(object sender, EventArgs e)
        {
            int whatPicture = 0;
            bool chk = true;
            if (set1_radio.Checked) whatPicture = 1;
            else if (set2_radio.Checked) whatPicture = 2;
            else if (set3_radio.Checked) whatPicture = 3;
            else if (set4_radio.Checked) whatPicture = 4;
            else if (set5_radio.Checked) whatPicture = 5;
            else
            {
                chk = false;
                MessageBox.Show("어떤 SET인지 선택해야 합니다.");
            }

            if (chk)
            {
                string picture_path = @"C:\Users\devLupin\Source\Repos\JointAngle_combine\JointAngle_combine\set_pictures\" + whatPicture + ".jpg";
                Picture picture = new Picture(picture_path);
                picture.Show();
            }
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
            bool chk = true;

            int opt = 0;
            if (set1_radio.Checked) opt = 1;
            else if (set2_radio.Checked) opt = 2;
            else if (set3_radio.Checked) opt = 3;
            else if (set4_radio.Checked) opt = 4;
            else if (set5_radio.Checked) opt = 5;
            else if (set6_radio.Checked) opt = 6;
            else
            {
                MessageBox.Show("아이디를 입력해야 합니다!");
                chk = false;
            }

            Database_set();

            // IF,,, not typing id
            if (chk)
            {
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
            }

            if (chk)
            {
                SpeechSynthesizer ts = new SpeechSynthesizer();
                ts.SelectVoice("Microsoft Server Speech Text to Speech Voice (ko-KR, Heami)");
                ts.SetOutputToDefaultAudioDevice();
                ts.Speak("SET " + opt + "의 측정을 시작합니다!");

                // Mesure program start 
                string path = @"C:\Users\devLupin\NuitrackSDK\Examples\nuitrack_measure_release\nuitrack_measure_release.exe";
                string argument = this.userID + " " + opt;

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
