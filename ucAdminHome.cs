using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TrungTamAnhVan
{
    public partial class ucAdminHome : UserControl
    {
        static ucAdminHome _obj;
        InformationBUS infoBUS = new InformationBUS();

        public static ucAdminHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucAdminHome();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                lbStudentQuantity.Text = infoBUS.CountStudent().ToString();
                lbTeacherQuantity.Text = infoBUS.CountTeacher().ToString();
                lbClassQuantity.Text = infoBUS.CountClass().ToString();
                lbCourseQuantity.Text = infoBUS.CountCourse().ToString();
            }
        }

        public ucAdminHome()
        {
            InitializeComponent();
        }

        private void ucAdminHome_Load(object sender, EventArgs e)
        {
            _obj = this;
            if (!DesignMode)
            {
                lbStudentQuantity.Text = infoBUS.CountStudent().ToString();
                lbTeacherQuantity.Text = infoBUS.CountTeacher().ToString();
                lbCourseQuantity.Text = infoBUS.CountCourse().ToString();
                lbClassQuantity.Text = infoBUS.CountClass().ToString();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditAdminPassword"))
            {
                ucEditAdminPassword uc = new ucEditAdminPassword();
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucEditAdminPassword"].BringToFront();
        }
    }
}
