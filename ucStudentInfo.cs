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
    public partial class ucStudentInfo : UserControl
    {
        static ucStudentInfo _obj;
        InformationBUS infoBUS = new InformationBUS();

        public static ucStudentInfo Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucStudentInfo();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            int id = frmStudentMain.ID;
            List<string> list = new List<string>();
            if (!DesignMode)
            {
                list = infoBUS.GetInfoStudent(id);
            }
            lbNameValue.Text = list[0];
            lbGenderValue.Text = list[1];
            DateTime dateBirth = Convert.ToDateTime(list[2]);
            lbDateBirthValue.Text = dateBirth.ToShortDateString();
            lbPhoneValue.Text = list[3];
            lbAddressValue.Text = list[4];
            lbLevelValue.Text = list[5];
        }
        public ucStudentInfo()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucStudentInfo_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                int id = frmStudentMain.ID;
                List<string> list = new List<string>();
                list = infoBUS.GetInfoStudent(id);
                lbNameValue.Text = list[0];
                lbGenderValue.Text = list[1];
                DateTime dateBirth = Convert.ToDateTime(list[2]);
                lbDateBirthValue.Text = dateBirth.ToShortDateString();
                lbPhoneValue.Text = list[3];
                lbAddressValue.Text = list[4];
                lbLevelValue.Text = list[5];
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!frmStudentMain.Instance.PnContainer.Controls.ContainsKey("ucEditStudent1"))
            {
                ucEditStudent1 uc = new ucEditStudent1(lbPhoneValue.Text, lbAddressValue.Text);
                uc.Dock = DockStyle.Fill;
                frmStudentMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmStudentMain.Instance.PnContainer.Controls["ucEditStudent1"].BringToFront();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!frmStudentMain.Instance.PnContainer.Controls.ContainsKey("ucEditStudentPassword"))
            {
                ucEditStudentPassword uc = new ucEditStudentPassword();
                uc.Dock = DockStyle.Fill;
                frmStudentMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmStudentMain.Instance.PnContainer.Controls["ucEditStudentPassword"].BringToFront();
        }
    }
}
