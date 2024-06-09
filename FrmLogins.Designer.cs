namespace CourseManagementSystem
{
    partial class FrmLogins
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.BtnStudentLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTeacherLogin = new System.Windows.Forms.Button();
            this.BtnAdvisorLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStudentLogin
            // 
            this.BtnStudentLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStudentLogin.BackgroundImage")));
            this.BtnStudentLogin.Location = new System.Drawing.Point(96, 401);
            this.BtnStudentLogin.Name = "BtnStudentLogin";
            this.BtnStudentLogin.Size = new System.Drawing.Size(206, 201);
            this.BtnStudentLogin.TabIndex = 0;
            this.BtnStudentLogin.UseVisualStyleBackColor = true;
            this.BtnStudentLogin.Click += new System.EventHandler(this.BtnStudentLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lovelo Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(126, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lovelo Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(525, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lovelo Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(895, 637);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Advisor";
            // 
            // BtnTeacherLogin
            // 
            this.BtnTeacherLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTeacherLogin.BackgroundImage")));
            this.BtnTeacherLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTeacherLogin.Location = new System.Drawing.Point(480, 401);
            this.BtnTeacherLogin.Name = "BtnTeacherLogin";
            this.BtnTeacherLogin.Size = new System.Drawing.Size(206, 201);
            this.BtnTeacherLogin.TabIndex = 6;
            this.BtnTeacherLogin.UseVisualStyleBackColor = true;
            this.BtnTeacherLogin.Click += new System.EventHandler(this.BtnTeacherLogin_Click);
            // 
            // BtnAdvisorLogin
            // 
            this.BtnAdvisorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdvisorLogin.BackgroundImage")));
            this.BtnAdvisorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdvisorLogin.Location = new System.Drawing.Point(842, 401);
            this.BtnAdvisorLogin.Name = "BtnAdvisorLogin";
            this.BtnAdvisorLogin.Size = new System.Drawing.Size(206, 201);
            this.BtnAdvisorLogin.TabIndex = 7;
            this.BtnAdvisorLogin.UseVisualStyleBackColor = true;
            this.BtnAdvisorLogin.Click += new System.EventHandler(this.BtnAdvisorLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 85);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gazi University";
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1183, 704);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAdvisorLogin);
            this.Controls.Add(this.BtnTeacherLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStudentLogin);
            this.MaximizeBox = false;
            this.Name = "FrmLogins";
            this.Text = "System Logins Panel";
            this.Load += new System.EventHandler(this.FrmLogins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStudentLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTeacherLogin;
        private System.Windows.Forms.Button BtnAdvisorLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

