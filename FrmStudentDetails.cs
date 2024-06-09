using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseManagementSystem
{
    public partial class FrmStudentDetails : Form
    {
        public FrmStudentDetails()
        {
            InitializeComponent();
        }

        public string tc; //form yüklenişine hazırlık yapıyoruz

        sqlbaglantisi bgl = new sqlbaglantisi(); //sql bağlantı işlemi
        private void FrmStudentDetails_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            



            //Ad ve soyada erişme
            NpgsqlCommand cmd = new NpgsqlCommand("Select stfname,stlname from students where sttc = @p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",LblTC.Text);
            NpgsqlDataReader dr = cmd.ExecuteReader(); //komut okuyucuyu çalıştırır
            while (dr.Read()) //veriler doğru okunduğu sürece...
            {
                LblFullName.Text = dr[0]+ " " + dr[1]; //hem araya boşluk koyduk hem de komut satırı içerisinde string ifade olduğu için diğer satırlara dönüştürme işlemi yapmaya gerek kalmadı
            }
            bgl.baglanti().Close();


            //aktif dersler sorgusu
            DataTable dt = new DataTable();
            string query = "SELECT * FROM lessons WHERE sttc = @StudentTC";
                using (NpgsqlCommand command = new NpgsqlCommand(query, bgl.baglanti()))
                {
                    command.Parameters.AddWithValue("@StudentTC", LblTC.Text.ToString());

                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            dataGridView1.DataSource = dt;

            /*departmanı gösterme
            NpgsqlCommand cmd2 = new NpgsqlCommand("select dpname from departments",bgl.baglanti());
            NpgsqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                Cmbdepartment.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();*/

            //departmanlara erişme bunu advisora yazdıracaz
            NpgsqlCommand cmd3 = new NpgsqlCommand("SELECT students.sttc, departments.dpname FROM students JOIN departments ON students.stdp = departments.dpid WHERE students.sttc = @StudentTC", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@StudentTC", LblTC.Text);
            NpgsqlDataReader dr3 = cmd3.ExecuteReader(); //komut okuyucuyu çalıştırır
            while (dr3.Read()) //veriler doğru okunduğu sürece...
            {
                Cmbdepartment.Items.Add(dr3[1] +""); //hem araya boşluk koyduk hem de komut satırı içerisinde string ifade olduğu için diğer satırlara dönüştürme işlemi yapmaya gerek kalmadı
            }
            bgl.baglanti().Close();

            /*NpgsqlCommand cmd3 = new NpgsqlCommand("SELECT students.sttc, departments.dpname FROM students JOIN departments ON students.stdp = departments.dpid WHERE students.sttc = @StudentTC", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@StudentTC", LblTC.Text);
            NpgsqlDataReader dr3 = cmd3.ExecuteReader(); //komut okuyucuyu çalıştırır
            while (dr3.Read()) //veriler doğru okunduğu sürece...
            {
                textBox1.Text=(dr3[1] + ""); //hem araya boşluk koyduk hem de komut satırı içerisinde string ifade olduğu için diğer satırlara dönüştürme işlemi yapmaya gerek kalmadı
            }
            bgl.baglanti().Close();*/


            //öğrencilerin duyuruları görüntülemesi
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from announcements", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

          private void Cmbdepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            NpgsqlCommand cmd4 = new NpgsqlCommand("SELECT teachers.* FROM teachers JOIN departments ON teachers.tcdp = departments.dpid WHERE departments.dpname = @p1 ",bgl.baglanti());
            cmd4.Parameters.AddWithValue("@p1", Cmbdepartment.Text);
            NpgsqlDataReader dr3 = cmd4.ExecuteReader();
            while (dr3.Read())
            {
                Cmbteachers.Items.Add(dr3[0] + " " + dr3[1] +"/" + dr3[5]);
            }
            bgl.baglanti() .Close();
        }

        private void LnkChangeInfos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.Tcno = LblTC.Text; //bilgi düzenleme sayfasına göndermek için...
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //burada öğretmeni seçip butona tıklatıktan sonra o öğretmenin dersinin numarasını görmek istiyoruz
            string selectedText = Cmbteachers.Text;
            string teacherName = selectedText.Substring(0, selectedText.IndexOf("/"));
            label2.Text = teacherName;
            string query1 = "SELECT lessonid FROM lessons WHERE lessonteacher = @Teacher AND lstatus <> true";
            NpgsqlCommand cmd = new NpgsqlCommand(query1, bgl.baglanti());  //örnek olarak baglanti() fonksiyonunun çağırılması
            cmd.Parameters.AddWithValue("@Teacher", label2.Text);
            NpgsqlDataReader dr3 = cmd.ExecuteReader();
            while (dr3.Read())
            {
                comboBox1.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void Cmbteachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("Update lessons set lstatus=true,sttc=@p1 where lessonid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", comboBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Lesson Added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLogins fr1 = new FrmLogins();
            fr1.Show();
            this.Close();
        }
    }
}
