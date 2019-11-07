namespace JointAngle_combine
{
    partial class AngleInfo_user
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
            this.AngleInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AngleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // AngleInfo
            // 
            this.AngleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AngleInfo.Location = new System.Drawing.Point(12, 6);
            this.AngleInfo.Name = "AngleInfo";
            this.AngleInfo.RowTemplate.Height = 23;
            this.AngleInfo.Size = new System.Drawing.Size(1046, 530);
            this.AngleInfo.TabIndex = 1;
            // 
            // AngleInfo_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 548);
            this.Controls.Add(this.AngleInfo);
            this.Name = "AngleInfo_user";
            this.Text = "사용자 관절각도 화면";
            ((System.ComponentModel.ISupportInitialize)(this.AngleInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AngleInfo;
    }
}