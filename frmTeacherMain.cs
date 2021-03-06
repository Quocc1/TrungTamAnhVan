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
    public partial class frmTeacherMain : Form
    {
        static frmTeacherMain _obj;
        public static int ID = 0;
        public static string NAME = "";

        public static frmTeacherMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmTeacherMain(NAME, ID);
                }
                return _obj;
            }
        }

        public Panel PnContainer
        {
            get { return pnContainer; }
            set { pnContainer = value; }
        }
        public frmTeacherMain(string name, int id)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            lbName.Text = NAME = name;
            ID = id;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            SetActivePanel(ucTeacherHome1);
        }

        public void SetActivePanel(UserControl control)
        {
            ucTeacherHome1.Visible = false;
            ucTeacherInfo1.Visible = false;
            ucTeacherClass1.Visible = false;
            ucTeacherSalary1.Visible = false;

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
            SetActivePanel(ucTeacherHome1);
            ucTeacherHome.Instance.Reload();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucTeacherInfo1);
            ucTeacherInfo.Instance.Reload();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucTeacherClass1);
            ucTeacherClass.Instance.Reload();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucTeacherSalary1);
            ucTeacherSalary.Instance.Reload();
        }
    }
}
