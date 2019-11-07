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
        const int NUM_OF_CULUMNS = 6;

        string userID = "";
        string userPW = "";

        string dbServer, dbName, dbUid, dbPwd, dbSslMode;
        string DB_INFO;

        MySqlConnection conn;


        // Index number setting
        enum DB_NUM { SET1, SET2, SET3, SET4, SET5, TIME };

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
            AngleInfo.ColumnCount = NUM_OF_CULUMNS;

            // Set the columns name
            for (int column_cnt = 0; column_cnt < AngleInfo.ColumnCount - 1; column_cnt++)
            {
                AngleInfo.Columns[column_cnt].Name = "SET " + (column_cnt + 1);
            }
            AngleInfo.Columns[AngleInfo.ColumnCount - 1].Name = "측정일자";
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
                        "SET1 INT NOT NULL, " +
                        "SET2 INT NOT NULL, " +
                        "SET3 INT NOT NULL, " +
                        "SET4 INT NOT NULL, " +
                        "SET5 INT NOT NULL, " +
                        "TIME DATETIME NOT NULL" +
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
                        row[(int)DB_NUM.SET1] = rdr["SET1"].ToString();
                        row[(int)DB_NUM.SET2] = rdr["SET2"].ToString();
                        row[(int)DB_NUM.SET3] = rdr["SET3"].ToString();
                        row[(int)DB_NUM.SET4] = rdr["SET4"].ToString();
                        row[(int)DB_NUM.SET5] = rdr["SET5"].ToString();
                        row[(int)DB_NUM.TIME] = DateTime.Now.ToString();    // current time.

                        // Show Data on DataGridView
                        AngleInfo.Rows.Add(
                            row[(int)DB_NUM.SET1], row[(int)DB_NUM.SET2], row[(int)DB_NUM.SET3], row[(int)DB_NUM.SET4], row[(int)DB_NUM.SET5], row[(int)DB_NUM.TIME]
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
