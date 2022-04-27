using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrungTamAnhVan
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain(string name)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            lbName.Text = name;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminHome1);
        }

        public void SetActivePanel(UserControl control)
        {
            ucAdminHome1.Visible = false;
            ucAdminStudent1.Visible = false;
            ucAdminTeacher1.Visible = false;
            ucAdminClass1.Visible = false;
            ucAdminCourse1.Visible = false;
            ucAdminFinance1.Visible = false;

            control.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminHome1);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminStudent1);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminTeacher1);
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminClass1);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminCourse1);
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminFinance1);
        }
    }
}
