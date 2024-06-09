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
    public partial class FrmStudentRegister : Form
    {
        public FrmStudentRegister()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("insert into students (Stid,Stfname,Stlname,Sttc,Stpn,Stpw,Stdp) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.Parameters.AddWithValue("@p2", TxtFname.Text);
            komut.Parameters.AddWithValue("@p3", TxtLname.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", MskPhone.Text);
            komut.Parameters.AddWithValue("@p6", TxtPassword.Text);
            komut.Parameters.AddWithValue("@p7", int.Parse(CmbDepartment.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Student creation completed successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void FrmStudentRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
