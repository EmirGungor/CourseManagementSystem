using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CourseManagementSystem
{
    public partial class FrmTeacherDetails : Form
    {
        public FrmTeacherDetails()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void FrmTeacherDetails_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            //Teacher ad soyad
            NpgsqlCommand komut = new NpgsqlCommand("select tcfname,tclname from teachers where tctc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            NpgsqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                LblAdSoyad.Text = reader[0] + " " + reader[1];

            }
            bgl.baglanti().Close();


            //Lesons
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from lessons where  lstatus = true and lessonteacher='"+LblAdSoyad.Text+"'", bgl.baglanti());

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmTeacherInfoCh fr = new FrmTeacherInfoCh();
            fr.TCNO = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fr = new FrmAnnouncements();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogins fr1 = new FrmLogins();
            fr1.Show();
            this.Close();
        }
    }
}
