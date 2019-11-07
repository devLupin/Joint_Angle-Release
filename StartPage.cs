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
                AngleInfo_user user = new AngleInfo_user(id_txt.Text, pw_txt.Text);
                user.Show();
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
