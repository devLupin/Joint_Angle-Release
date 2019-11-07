namespace JointAngle_combine
{
    partial class StartPage_UI
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.admin_radio = new System.Windows.Forms.RadioButton();
            this.member_radio = new System.Windows.Forms.RadioButton();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("굴림", 15F);
            this.login_btn.Location = new System.Drawing.Point(463, 84);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(118, 74);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // join_btn
            // 
            this.join_btn.Font = new System.Drawing.Font("굴림", 15F);
            this.join_btn.Location = new System.Drawing.Point(587, 84);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(118, 74);
            this.join_btn.TabIndex = 1;
            this.join_btn.Text = "회원가입";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("굴림", 15F);
            this.id_label.Location = new System.Drawing.Point(217, 94);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(69, 20);
            this.id_label.TabIndex = 2;
            this.id_label.Text = "아이디";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("굴림", 15F);
            this.pw_label.Location = new System.Drawing.Point(197, 120);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(89, 20);
            this.pw_label.TabIndex = 3;
            this.pw_label.Text = "비밀번호";
            // 
            // admin_radio
            // 
            this.admin_radio.AutoSize = true;
            this.admin_radio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_radio.Font = new System.Drawing.Font("굴림", 15F);
            this.admin_radio.Location = new System.Drawing.Point(268, 153);
            this.admin_radio.Name = "admin_radio";
            this.admin_radio.Size = new System.Drawing.Size(86, 24);
            this.admin_radio.TabIndex = 4;
            this.admin_radio.TabStop = true;
            this.admin_radio.Text = "관리자";
            this.admin_radio.UseVisualStyleBackColor = true;
            // 
            // member_radio
            // 
            this.member_radio.AutoSize = true;
            this.member_radio.Font = new System.Drawing.Font("굴림", 15F);
            this.member_radio.Location = new System.Drawing.Point(360, 153);
            this.member_radio.Name = "member_radio";
            this.member_radio.Size = new System.Drawing.Size(67, 24);
            this.member_radio.TabIndex = 5;
            this.member_radio.TabStop = true;
            this.member_radio.Text = "회원";
            this.member_radio.UseVisualStyleBackColor = true;
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.id_txt.Location = new System.Drawing.Point(292, 84);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(165, 30);
            this.id_txt.TabIndex = 6;
            // 
            // pw_txt
            // 
            this.pw_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.pw_txt.Location = new System.Drawing.Point(292, 117);
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.PasswordChar = '●';
            this.pw_txt.Size = new System.Drawing.Size(165, 30);
            this.pw_txt.TabIndex = 7;
            // 
            // StartPage_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pw_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.member_radio);
            this.Controls.Add(this.admin_radio);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.login_btn);
            this.Name = "StartPage_UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.RadioButton admin_radio;
        private System.Windows.Forms.RadioButton member_radio;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox pw_txt;
    }
}

