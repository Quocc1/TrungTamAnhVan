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
        static frmAdminMain _obj;
        static string NAME = "";

        public static frmAdminMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmAdminMain(NAME);
                }
                return _obj;
            }
        }

        public Panel PnContainer
        {
            get { return pnContainer; }
            set { pnContainer = value; }
        }
        public frmAdminMain(string name)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            lbName.Text = NAME = name;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
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
            ucAdminHome.Instance.Reload();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminStudent1);
            ucAdminStudent.Instance.Reload();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminTeacher1);
            ucAdminTeacher.Instance.Reload();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminClass1);
            ucAdminClass.Instance.Reload();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminCourse1);
            ucAdminCourse.Instance.Reload();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucAdminFinance1);
            ucAdminFinance.Instance.Reload();
        }
    }
}
