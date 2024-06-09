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
    public partial class FrmAdvisorLogin : Form
    {
        public FrmAdvisorLogin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select * from advisors where adtc=@p1 and adpw=@p2",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPw.Text);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) //girişlerde kontrolü sağlamak için if kullanıyoruz
            {
                FrmAdvisorDetails fr = new FrmAdvisorDetails();
                fr.Tcno = MskTC.Text; //sekreterin tcsini görebilmesini sağlamak
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Entry!");
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
