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
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDepartments_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from departments", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("insert into departments (dpname) values(@d1) ", bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1", TxtBrans.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("New department added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }
        
        private void BtnSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("delete from departments where dpid=@d1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1", int.Parse(Txtid.Text));
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Department deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("update departments set dpname=@d1 where dpid=@d2", bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1", TxtBrans.Text);
            cmd.Parameters.AddWithValue("@d2", int.Parse(Txtid.Text));
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Department updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
