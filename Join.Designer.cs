namespace JointAngle_combine
{
    partial class Join
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.save_btn = new System.Windows.Forms.Button();
            this.sex_woman = new System.Windows.Forms.RadioButton();
            this.sex_man = new System.Windows.Forms.RadioButton();
            this.age_txt = new System.Windows.Forms.TextBox();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.sex_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("굴림", 16F);
            this.save_btn.Location = new System.Drawing.Point(306, 302);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(150, 69);
            this.save_btn.TabIndex = 23;
            this.save_btn.Text = "저장하기";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // sex_woman
            // 
            this.sex_woman.AutoSize = true;
            this.sex_woman.Location = new System.Drawing.Point(442, 254);
            this.sex_woman.Name = "sex_woman";
            this.sex_woman.Size = new System.Drawing.Size(47, 16);
            this.sex_woman.TabIndex = 22;
            this.sex_woman.TabStop = true;
            this.sex_woman.Text = "여성";
            this.sex_woman.UseVisualStyleBackColor = true;
            // 
            // sex_man
            // 
            this.sex_man.AutoSize = true;
            this.sex_man.Location = new System.Drawing.Point(389, 254);
            this.sex_man.Name = "sex_man";
            this.sex_man.Size = new System.Drawing.Size(47, 16);
            this.sex_man.TabIndex = 21;
            this.sex_man.TabStop = true;
            this.sex_man.Text = "남성";
            this.sex_man.UseVisualStyleBackColor = true;
            // 
            // age_txt
            // 
            this.age_txt.Location = new System.Drawing.Point(389, 209);
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(100, 21);
            this.age_txt.TabIndex = 20;
            // 
            // pw_txt
            // 
            this.pw_txt.Location = new System.Drawing.Point(389, 163);
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.Size = new System.Drawing.Size(100, 21);
            this.pw_txt.TabIndex = 19;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(389, 114);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 21);
            this.id_txt.TabIndex = 18;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(389, 66);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 21);
            this.name_txt.TabIndex = 17;
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Font = new System.Drawing.Font("굴림", 13F);
            this.sex_label.Location = new System.Drawing.Point(339, 252);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(44, 18);
            this.sex_label.TabIndex = 16;
            this.sex_label.Text = "성별";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("굴림", 13F);
            this.age_label.Location = new System.Drawing.Point(237, 212);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(146, 18);
            this.age_label.TabIndex = 15;
            this.age_label.Text = "나이(숫자만입력)";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("굴림", 13F);
            this.pw_label.Location = new System.Drawing.Point(303, 163);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(80, 18);
            this.pw_label.TabIndex = 14;
            this.pw_label.Text = "비밀번호";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("굴림", 13F);
            this.ID_label.Location = new System.Drawing.Point(321, 114);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(62, 18);
            this.ID_label.TabIndex = 13;
            this.ID_label.Text = "아이디";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("굴림", 13F);
            this.name_label.Location = new System.Drawing.Point(339, 69);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(44, 18);
            this.name_label.TabIndex = 12;
            this.name_label.Text = "이름";
            // 
            // Join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.sex_woman);
            this.Controls.Add(this.sex_man);
            this.Controls.Add(this.age_txt);
            this.Controls.Add(this.pw_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.sex_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.name_label);
            this.Name = "Join";
            this.Text = "회원가입(only for user)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.RadioButton sex_woman;
        private System.Windows.Forms.RadioButton sex_man;
        private System.Windows.Forms.TextBox age_txt;
        private System.Windows.Forms.TextBox pw_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label name_label;
    }
}