namespace JointAngle_combine
{
    partial class Admin
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
            this.set1_radio = new System.Windows.Forms.RadioButton();
            this.set2_radio = new System.Windows.Forms.RadioButton();
            this.set3_radio = new System.Windows.Forms.RadioButton();
            this.set4_radio = new System.Windows.Forms.RadioButton();
            this.set5_radio = new System.Windows.Forms.RadioButton();
            this.id_label = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.measureStart_btn = new System.Windows.Forms.Button();
            this.userResult_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // set1_radio
            // 
            this.set1_radio.AutoSize = true;
            this.set1_radio.Font = new System.Drawing.Font("굴림", 15F);
            this.set1_radio.Location = new System.Drawing.Point(153, 124);
            this.set1_radio.Name = "set1_radio";
            this.set1_radio.Size = new System.Drawing.Size(82, 24);
            this.set1_radio.TabIndex = 0;
            this.set1_radio.TabStop = true;
            this.set1_radio.Text = "SET 1";
            this.set1_radio.UseVisualStyleBackColor = true;
            // 
            // set2_radio
            // 
            this.set2_radio.AutoSize = true;
            this.set2_radio.Font = new System.Drawing.Font("굴림", 15F);
            this.set2_radio.Location = new System.Drawing.Point(241, 124);
            this.set2_radio.Name = "set2_radio";
            this.set2_radio.Size = new System.Drawing.Size(82, 24);
            this.set2_radio.TabIndex = 1;
            this.set2_radio.TabStop = true;
            this.set2_radio.Text = "SET 2";
            this.set2_radio.UseVisualStyleBackColor = true;
            // 
            // set3_radio
            // 
            this.set3_radio.AutoSize = true;
            this.set3_radio.Font = new System.Drawing.Font("굴림", 15F);
            this.set3_radio.Location = new System.Drawing.Point(329, 124);
            this.set3_radio.Name = "set3_radio";
            this.set3_radio.Size = new System.Drawing.Size(82, 24);
            this.set3_radio.TabIndex = 2;
            this.set3_radio.TabStop = true;
            this.set3_radio.Text = "SET 3";
            this.set3_radio.UseVisualStyleBackColor = true;
            // 
            // set4_radio
            // 
            this.set4_radio.AutoSize = true;
            this.set4_radio.Font = new System.Drawing.Font("굴림", 15F);
            this.set4_radio.Location = new System.Drawing.Point(417, 124);
            this.set4_radio.Name = "set4_radio";
            this.set4_radio.Size = new System.Drawing.Size(89, 24);
            this.set4_radio.TabIndex = 3;
            this.set4_radio.TabStop = true;
            this.set4_radio.Text = "SET  4";
            this.set4_radio.UseVisualStyleBackColor = true;
            // 
            // set5_radio
            // 
            this.set5_radio.AutoSize = true;
            this.set5_radio.Font = new System.Drawing.Font("굴림", 15F);
            this.set5_radio.Location = new System.Drawing.Point(512, 124);
            this.set5_radio.Name = "set5_radio";
            this.set5_radio.Size = new System.Drawing.Size(82, 24);
            this.set5_radio.TabIndex = 4;
            this.set5_radio.TabStop = true;
            this.set5_radio.Text = "SET 5";
            this.set5_radio.UseVisualStyleBackColor = true;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("굴림", 15F);
            this.id_label.Location = new System.Drawing.Point(143, 239);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(69, 20);
            this.id_label.TabIndex = 5;
            this.id_label.Text = "아이디";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(218, 238);
            this.id_txt.Name = "id_txt";
            this.id_txt.PasswordChar = '●';
            this.id_txt.Size = new System.Drawing.Size(100, 21);
            this.id_txt.TabIndex = 6;
            // 
            // measureStart_btn
            // 
            this.measureStart_btn.Font = new System.Drawing.Font("굴림", 15F);
            this.measureStart_btn.Location = new System.Drawing.Point(343, 214);
            this.measureStart_btn.Name = "measureStart_btn";
            this.measureStart_btn.Size = new System.Drawing.Size(126, 67);
            this.measureStart_btn.TabIndex = 7;
            this.measureStart_btn.Text = "측정시작";
            this.measureStart_btn.UseVisualStyleBackColor = true;
            this.measureStart_btn.Click += new System.EventHandler(this.measureStart_btn_Click);
            // 
            // userResult_btn
            // 
            this.userResult_btn.Font = new System.Drawing.Font("굴림", 15F);
            this.userResult_btn.Location = new System.Drawing.Point(499, 214);
            this.userResult_btn.Name = "userResult_btn";
            this.userResult_btn.Size = new System.Drawing.Size(151, 67);
            this.userResult_btn.TabIndex = 8;
            this.userResult_btn.Text = "전체결과 보기";
            this.userResult_btn.UseVisualStyleBackColor = true;
            this.userResult_btn.Click += new System.EventHandler(this.userResult_btn_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userResult_btn);
            this.Controls.Add(this.measureStart_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.set5_radio);
            this.Controls.Add(this.set4_radio);
            this.Controls.Add(this.set3_radio);
            this.Controls.Add(this.set2_radio);
            this.Controls.Add(this.set1_radio);
            this.Name = "Admin";
            this.Text = "관절각도 측정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton set1_radio;
        private System.Windows.Forms.RadioButton set2_radio;
        private System.Windows.Forms.RadioButton set3_radio;
        private System.Windows.Forms.RadioButton set4_radio;
        private System.Windows.Forms.RadioButton set5_radio;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button measureStart_btn;
        private System.Windows.Forms.Button userResult_btn;
    }
}