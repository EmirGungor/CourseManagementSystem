namespace CourseManagementSystem
{
    partial class FrmStudentRegister
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
            this.BtnRegister = new System.Windows.Forms.Button();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFname = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtLname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.BtnRegister.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRegister.Location = new System.Drawing.Point(140, 421);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(173, 49);
            this.BtnRegister.TabIndex = 33;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // MskPhone
            // 
            this.MskPhone.Location = new System.Drawing.Point(220, 269);
            this.MskPhone.Mask = "(999) 000-0000";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(173, 20);
            this.MskPhone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Student Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Student Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(220, 324);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(173, 20);
            this.TxtPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Student Id:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(220, 56);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(173, 20);
            this.TxtId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Student First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Student Last Name:";
            // 
            // TxtFname
            // 
            this.TxtFname.Location = new System.Drawing.Point(220, 106);
            this.TxtFname.Name = "TxtFname";
            this.TxtFname.Size = new System.Drawing.Size(173, 20);
            this.TxtFname.TabIndex = 2;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(222, 213);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(173, 20);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtLname
            // 
            this.TxtLname.Location = new System.Drawing.Point(222, 158);
            this.TxtLname.Name = "TxtLname";
            this.TxtLname.Size = new System.Drawing.Size(173, 20);
            this.TxtLname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(84, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Student TC No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Student Department:";
            // 
            // CmbDepartment
            // 
            this.CmbDepartment.FormattingEnabled = true;
            this.CmbDepartment.Location = new System.Drawing.Point(220, 371);
            this.CmbDepartment.Name = "CmbDepartment";
            this.CmbDepartment.Size = new System.Drawing.Size(173, 21);
            this.CmbDepartment.TabIndex = 7;
            // 
            // FrmStudentRegister
            // 
            this.AcceptButton = this.BtnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(462, 497);
            this.Controls.Add(this.CmbDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtLname);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.MskPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtFname);
            this.Controls.Add(this.MskTC);
            this.Name = "FrmStudentRegister";
            this.Text = "Student Register Panel";
            this.Load += new System.EventHandler(this.FrmStudentRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFname;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtLname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbDepartment;
    }
}