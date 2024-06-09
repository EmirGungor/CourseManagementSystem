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
    public partial class FrmLessonList : Form
    {
        public FrmLessonList()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmLessonList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from lessons",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
