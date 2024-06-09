using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManagementSystem
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void BtnStudentLogin_Click(object sender, EventArgs e)
        {
            FrmStLogin fr = new FrmStLogin();
            fr.Show();
            this.Hide();
        }

        private void BtnTeacherLogin_Click(object sender, EventArgs e)
        {
            FrmTeacherLogin fr = new FrmTeacherLogin();
            fr.Show();
            this.Hide();
        }

        private void BtnAdvisorLogin_Click(object sender, EventArgs e)
        {
            FrmAdvisorLogin fr = new FrmAdvisorLogin();
            fr.Show();
            this.Hide();
        }

        private void FrmLogins_Load(object sender, EventArgs e)
        {

        }
    }
}
