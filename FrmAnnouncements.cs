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
    public partial class FrmAnnouncements : Form
    {
        public FrmAnnouncements()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from announcements", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
