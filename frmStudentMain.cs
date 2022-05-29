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
    public partial class frmStudentMain : Form
    {
        static frmStudentMain _obj;
        public static int ID = 0;
        public static string NAME = "";

        public static frmStudentMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmStudentMain(NAME, ID);
                }
                return _obj;
            }
        }

        public Panel PnContainer
        {
            get { return pnContainer; }
            set { pnContainer = value; }
        }
        public frmStudentMain(string name, int id)
        {
            InitializeComponent();
            Load += FrmMain_Load;
            lbName.Text = NAME = name;
            ID = id;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
            SetActivePanel(ucStudentHome1);
        }

        public void SetActivePanel(UserControl control)
        {
            ucStudentHome1.Visible = false;
            ucStudentInfo1.Visible = false;
            ucStudentSchedule1.Visible = false;
            ucStudentScore1.Visible = false;
            ucStudentFee1.Visible = false;

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
            SetActivePanel(ucStudentHome1);
            ucStudentHome.Instance.Reload();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucStudentInfo1);
            ucStudentInfo.Instance.Reload();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucStudentSchedule1);
            ucStudentSchedule.Instance.Reload();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucStudentScore1);
            ucStudentScore.Instance.Reload();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucStudentFee1);
            ucStudentFee.Instance.Reload();
        }
    }
}
