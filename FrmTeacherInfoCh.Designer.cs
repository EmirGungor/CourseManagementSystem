namespace CourseManagementSystem
{
    partial class FrmTeacherInfoCh
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
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtLname = new System.Windows.Forms.TextBox();
            this.BtnChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFname = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(235, 288);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(173, 21);
            this.CmbDepartment.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(98, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 67;
            this.label6.Text = "Department:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(146, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 66;
            this.label7.Text = "TC No:";
            // 
            // TxtLname
            // 
            this.TxtLname.Location = new System.Drawing.Point(237, 131);
            this.TxtLname.Name = "TxtLname";
            this.TxtLname.Size = new System.Drawing.Size(173, 20);
            this.TxtLname.TabIndex = 65;
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.LightGreen;
            this.BtnChange.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnChange.Location = new System.Drawing.Point(160, 389);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(173, 49);
            this.BtnChange.TabIndex = 64;
            this.BtnChange.Text = "Accept Changes";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(116, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(235, 241);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(173, 20);
            this.TxtPassword.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(108, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Last Name:";
            // 
            // TxtFname
            // 
            this.TxtFname.Location = new System.Drawing.Point(235, 79);
            this.TxtFname.Name = "TxtFname";
            this.TxtFname.Size = new System.Drawing.Size(173, 20);
            this.TxtFname.TabIndex = 55;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(237, 186);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(173, 20);
            this.MskTC.TabIndex = 56;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // FrmTeacherInfoCh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(476, 449);
            this.Controls.Add(this.CmbDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtLname);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFname);
            this.Controls.Add(this.MskTC);
            this.Name = "FrmTeacherInfoCh";
            this.Text = "FrmTeacherInfoCh";
            this.Load += new System.EventHandler(this.FrmTeacherInfoCh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtLname;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFname;
        private System.Windows.Forms.MaskedTextBox MskTC;
    }
}