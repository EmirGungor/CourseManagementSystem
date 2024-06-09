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
    public partial class FrmTeacherInfoCh : Form
    {
        public FrmTeacherInfoCh()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;
        private void FrmTeacherInfoCh_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNO;

            NpgsqlCommand komut = new NpgsqlCommand("Select * from teachers where tctc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtFname.Text = dr[0].ToString();
                TxtLname.Text = dr[1].ToString();
                TxtPassword.Text= dr[3].ToString();
                CmbDepartment.Text= dr[4].ToString();
            }
            bgl.baglanti().Close();

        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("update teachers set tcfname=@p1,tclname=@p2,tcpw=@p3 where tctc = @p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtFname.Text);
            komut.Parameters.AddWithValue("@p2", TxtLname.Text);
            komut.Parameters.AddWithValue("@p3", TxtPassword.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Teacher Updated");


        }
    }
}
