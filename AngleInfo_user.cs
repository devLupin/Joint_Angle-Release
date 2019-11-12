using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JointAngle_combine
{
    public partial class AngleInfo_user : Form
    {

        /**
         * Database name == id
         * Set num of field
         * 
         * <-------- List -------->
         * SET1 ~ SET5, Current time
         */
        const int NUM_OF_CULUMNS = 3;

        string userID = "";
        string userPW = "";

        string dbServer, dbName, dbUid, dbPwd, dbSslMode;
        string DB_INFO;

        MySqlConnection conn;


        // Index number setting
        enum DB_NUM { TYPE, ANGLE, TIME };

        //Set the database info
        private void Database_set()
        {
            dbServer = "localhost";
            dbName = "JA_USER_INFO";
            dbUid = "devLupin";
            dbPwd = "lht1080";
            dbSslMode = "none";

            DB_INFO = "Data Source=" + dbServer + ";" + "Database=" + dbName + ";" + "User Id=" + dbUid + ";" + "Password=" + dbPwd + ";charset=euckr";
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(AngleInfo);

            // Num of columns
            AngleInfo.ColumnCount = 3;

            // Set the columns name
            AngleInfo.Columns[(int)DB_NUM.TYPE].Name = "타입";
            AngleInfo.Columns[(int)DB_NUM.ANGLE].Name = "각도";
            AngleInfo.Columns[(int)DB_NUM.TIME].Name = "측정일자";
        }

        private void PopulateDataGridView()
        {
            // num of column of Datagridview
            string[] row = new string[AngleInfo.ColumnCount];

            Database_set();

            using (conn = new MySqlConnection(DB_INFO))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }


                /*
                 * If not exist database of userId, DB creation
                 * If exist, skip
                 */
                try
                {
                    string create_sql = "CREATE TABLE IF NOT EXISTS " + this.userID + " (" +
                        "TYPE VARCHAR(10) NOT NULL, " +
                        "ANGLE INT NOT NULL, " +
                        "TIME VARCHAR(40) NOT NULL" +
                        ")";
                    MySqlCommand create_cmd = new MySqlCommand(create_sql, conn);
                    create_cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("CREATE TABLE USER_ID error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

                /*
                 * Save angle data to database of userID
                 * And, ready to show the DataGridView
                 */
                try
                {
                    string sql = "SELECT * FROM " + this.userID;      // All data of INFO table.
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        // Set Angle data & curTime;
                        row[(int)DB_NUM.TYPE] = rdr["TYPE"].ToString();
                        row[(int)DB_NUM.ANGLE] = rdr["ANGLE"].ToString();
                        row[(int)DB_NUM.TIME] = DateTime.Now.ToString();    // current time.

                        // Show Data on DataGridView
                        AngleInfo.Rows.Add(
                            row[(int)DB_NUM.TYPE], row[(int)DB_NUM.ANGLE], row[(int)DB_NUM.TIME]
                            );
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("SELECT * FROM USER_ID error!");
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }

            conn.Close();
        }

        public AngleInfo_user(string id, string pw)
        {
            this.userID = id;
            this.userPW = pw;

            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();
        }

        // For admin measure layout
        public AngleInfo_user(string id)
        {
            this.userID = id;

            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();
        }
    }
}
