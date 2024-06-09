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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseManagementSystem
{
    public partial class FrmTeacherPanel : Form
    {
        public FrmTeacherPanel()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmTeacherPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from teachers", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("insert into teachers (tcfname,tclname,tctc,tcpw,tcdp,tclessons) values (@t1,@t2,@t3,@t4,@t5,@t6)", bgl.baglanti());
            cmd.Parameters.AddWithValue("@t1", TxtfName.Text);
            cmd.Parameters.AddWithValue("@t2", TxtLname.Text);
            cmd.Parameters.AddWithValue("@t3", MskTC.Text);
            cmd.Parameters.AddWithValue("@t4", TxtPw.Text);
            cmd.Parameters.AddWithValue("@t5", int.Parse(CmbDepartment.Text));
            cmd.Parameters.AddWithValue("@t6", txtlesson.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("New teacher added successfully!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtfName.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtLname.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtPw.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
           CmbDepartment.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtlesson.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("delete from teachers where tctc=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",MskTC.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Teacher deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("update teachers set tcfname=@t1,tclname=@t2,tcpw=@t4,tcdp=@t5,tclessons=@t6 where tctc=@t3 ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@t1", TxtfName.Text);
            cmd.Parameters.AddWithValue("@t2", TxtLname.Text);
            cmd.Parameters.AddWithValue("@t3", MskTC.Text);
            cmd.Parameters.AddWithValue("@t4", TxtPw.Text);
            cmd.Parameters.AddWithValue("@t5", int.Parse(CmbDepartment.Text));
            cmd.Parameters.AddWithValue("@t6", txtlesson.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Teacher update successfully!");
        }
    }
}
