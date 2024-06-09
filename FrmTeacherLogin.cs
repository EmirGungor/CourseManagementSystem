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
    public partial class FrmTeacherLogin : Form
    {
        public FrmTeacherLogin()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmTeacherLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select * from teachers where tctc=@p1 and tcpw=@p2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPw.Text);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmTeacherDetails fr = new FrmTeacherDetails();
                fr.TC=MskTC.Text; //teacher logine yazdığımız puclic TC değişkinin değerini buradaki msktc değerinden çekiyoruz
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Entry!");
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogins fr1 = new FrmLogins();
            fr1.Show();
            this.Close();
        }
    }
}
