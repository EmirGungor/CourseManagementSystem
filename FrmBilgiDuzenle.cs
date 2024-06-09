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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string Tcno;
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
           
            MskTC.Text=Tcno;
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT students.*, departments.dpname\r\nFROM students\r\nINNER JOIN departments ON students.stdp = departments.dpid where sttc=@p1", bgl.baglanti());
            //öğrencinin departman adına ulaşmak için inner join kullanmamız gerekti buna stdp deki numaradan ulaşabildik
            cmd.Parameters.AddWithValue("@p1",MskTC.Text);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TxtId.Text = dr[5].ToString();
                TxtFname.Text = dr[0].ToString();
                TxtLname.Text = dr[1].ToString();
                MskPhone.Text = dr[4].ToString();
                TxtPassword.Text = dr[2].ToString();
                CmbDepartment.Text = dr[7].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd2 = new NpgsqlCommand("update students set stfname=@p1,stlname=@p2,stpw=@p3,stpn=@p4 where sttc=@p5",bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1", TxtFname.Text);
            cmd2.Parameters.AddWithValue("@p2", TxtLname.Text);
            cmd2.Parameters.AddWithValue("@p3", TxtPassword.Text);
            cmd2.Parameters.AddWithValue("@p4", MskPhone.Text);
            cmd2.Parameters.AddWithValue("@p5", MskTC.Text);
            cmd2.ExecuteNonQuery(); //veritabanında değişikliğe yol açacak olan sorgularda mutlaka kullanılmalı
            bgl.baglanti().Close();
            MessageBox.Show("Your information has been successfully updated","Info",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}
