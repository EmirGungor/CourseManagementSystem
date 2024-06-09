using Npgsql;
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
    public partial class FrmAdvisorDetails : Form
    {
        public FrmAdvisorDetails()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string Tcno;

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentRegister fr = new FrmStudentRegister();
            fr.Show();
            
        }

        private void FrmAdvisorDetails_Load(object sender, EventArgs e)
        {
            LblTC.Text = Tcno; //tc erişim
            //Ad ve soyada erişme
            NpgsqlCommand cmd = new NpgsqlCommand("Select adfullname from advisors where adtc = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", LblTC.Text);
            NpgsqlDataReader dr = cmd.ExecuteReader(); //komut okuyucuyu çalıştırır
            while (dr.Read()) //veriler doğru okunduğu sürece...
            {
                LblAdSoyad.Text = dr[0] + " "; //hem araya boşluk koyduk hem de komut satırı içerisinde string ifade olduğu için diğer satırlara dönüştürme işlemi yapmaya gerek kalmadı
            }
            bgl.baglanti().Close();

            //Dersleri datagride alma
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from lessons", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Öğretmenleri listeye aktarma
            DataTable dt2 = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select concat(tcfname, ' ', tclname) as teacher_fullname, tclessons, tcdp from teachers", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //öğretmen adının otomatik olarak comboboxa dolmasını istiyoruz
            NpgsqlCommand cmd3 = new NpgsqlCommand("select concat(tcfname, ' ', tclname) as tc from teachers",bgl.baglanti());
            NpgsqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            NpgsqlCommand create = new NpgsqlCommand("insert into lessons (lessonid,lessonname,lessonteacher,ldp,lstatus) values (@p1,@p2,@p3,@p4,false) ",bgl.baglanti());
            create.Parameters.AddWithValue("@p1",Txtid.Text);
            create.Parameters.AddWithValue("@p2",txtname.Text);
            create.Parameters.AddWithValue("@p3",comboBox1.Text);
            create.Parameters.AddWithValue("@p4",int.Parse( txtdp.Text));

            create.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Lesson created successfully");
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            NpgsqlCommand create1 = new NpgsqlCommand("insert into announcements (content) values (@a1) ", bgl.baglanti());
            create1.Parameters.AddWithValue("@a1", RchDuyuru.Text);
            create1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Announcement created succesfully!");

        }

        private void BtnTeacherPanel_Click(object sender, EventArgs e)
        {
            FrmTeacherPanel drp = new FrmTeacherPanel();
            drp.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmDepartments frdp = new FrmDepartments();
            frdp.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmLessonList fr = new FrmLessonList();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fr = new FrmAnnouncements();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmLogins fr1 = new FrmLogins();
            fr1.Show();
            this.Close();
        }
    }
}
