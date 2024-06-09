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
    public partial class FrmStLogin : Form
    {
        public FrmStLogin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("Select * from students where sttc=@p1 and stpw=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtPw.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmStudentDetails fr = new FrmStudentDetails();
                fr.tc=MskTC.Text; //fr nesnesi aracılığıyla tc ye erişip mskTC deki öğrenciye ait tc yi taşıyoruz
                fr.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
            bgl.baglanti().Close();
        }

        private void FrmStLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogins fr1=new FrmLogins();
            fr1.Show();
            this.Close();
        }
    }
}
