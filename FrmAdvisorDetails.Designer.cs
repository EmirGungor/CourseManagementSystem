namespace CourseManagementSystem
{
    partial class FrmAdvisorDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnListe = new System.Windows.Forms.Button();
            this.BtnTeacherPanel = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnBransPanel = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtdp = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDuyuruOlustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Announcements";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnListe
            // 
            this.BtnListe.Location = new System.Drawing.Point(302, 44);
            this.BtnListe.Name = "BtnListe";
            this.BtnListe.Size = new System.Drawing.Size(136, 63);
            this.BtnListe.TabIndex = 13;
            this.BtnListe.Text = "Lesson List";
            this.BtnListe.UseVisualStyleBackColor = true;
            this.BtnListe.Click += new System.EventHandler(this.BtnListe_Click);
            // 
            // BtnTeacherPanel
            // 
            this.BtnTeacherPanel.Location = new System.Drawing.Point(6, 44);
            this.BtnTeacherPanel.Name = "BtnTeacherPanel";
            this.BtnTeacherPanel.Size = new System.Drawing.Size(146, 63);
            this.BtnTeacherPanel.TabIndex = 11;
            this.BtnTeacherPanel.Text = "Teacher Panel";
            this.BtnTeacherPanel.UseVisualStyleBackColor = true;
            this.BtnTeacherPanel.Click += new System.EventHandler(this.BtnTeacherPanel_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnListe);
            this.groupBox6.Controls.Add(this.BtnBransPanel);
            this.groupBox6.Controls.Add(this.BtnTeacherPanel);
            this.groupBox6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(22, 473);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(605, 205);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Early Access";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 63);
            this.button2.TabIndex = 15;
            this.button2.Text = "Students Panel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnBransPanel
            // 
            this.BtnBransPanel.Location = new System.Drawing.Point(159, 44);
            this.BtnBransPanel.Name = "BtnBransPanel";
            this.BtnBransPanel.Size = new System.Drawing.Size(129, 63);
            this.BtnBransPanel.TabIndex = 12;
            this.BtnBransPanel.Text = "Department Panel";
            this.BtnBransPanel.UseVisualStyleBackColor = true;
            this.BtnBransPanel.Click += new System.EventHandler(this.BtnBransPanel_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(500, 273);
            this.dataGridView2.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(668, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(506, 303);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Teachers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 254);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(665, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(506, 284);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lessons";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(15, 353);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(261, 51);
            this.BtnOlustur.TabIndex = 7;
            this.BtnOlustur.Text = "Create Lesson";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(112, 35);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(121, 31);
            this.Txtid.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advisor Informations";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(91, 55);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(76, 23);
            this.LblAdSoyad.TabIndex = 4;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(101, 99);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 3;
            this.LblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.txtdp);
            this.groupBox3.Controls.Add(this.txtname);
            this.groupBox3.Controls.Add(this.BtnOlustur);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(334, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 433);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Lesson";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 17;
            // 
            // txtdp
            // 
            this.txtdp.Location = new System.Drawing.Point(112, 174);
            this.txtdp.Name = "txtdp";
            this.txtdp.Size = new System.Drawing.Size(121, 31);
            this.txtdp.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(112, 79);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 31);
            this.txtname.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dp No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Teacher:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lesson Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(21, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 232);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Announcements";
            // 
            // BtnDuyuruOlustur
            // 
            this.BtnDuyuruOlustur.Location = new System.Drawing.Point(16, 196);
            this.BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            this.BtnDuyuruOlustur.Size = new System.Drawing.Size(261, 30);
            this.BtnDuyuruOlustur.TabIndex = 6;
            this.BtnDuyuruOlustur.Text = "Create";
            this.BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.BtnDuyuruOlustur.Click += new System.EventHandler(this.BtnDuyuruOlustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(16, 30);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(261, 160);
            this.RchDuyuru.TabIndex = 6;
            this.RchDuyuru.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmAdvisorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(100)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1274, 714);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdvisorDetails";
            this.Text = "Advisor Details";
            this.Load += new System.EventHandler(this.FrmAdvisorDetails_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnListe;
        private System.Windows.Forms.Button BtnTeacherPanel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnBransPanel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtdp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
    }
}