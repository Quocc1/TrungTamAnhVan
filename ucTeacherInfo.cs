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
    public partial class ucTeacherInfo : UserControl
    {
        static ucTeacherInfo _obj;
        InformationBUS infoBUS = new InformationBUS();

        public static ucTeacherInfo Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucTeacherInfo();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            int id = frmTeacherMain.ID;
            List<string> list = new List<string>();
            if (!DesignMode)
            {
                list = infoBUS.GetInfoTeacher(id);
            }
            lbNameValue.Text = list[0];
            lbGenderValue.Text = list[1];
            DateTime dateBirth = Convert.ToDateTime(list[2]);
            lbDateBirthValue.Text = dateBirth.ToShortDateString();
            lbPhoneValue.Text = list[3];
            lbAddressValue.Text = list[4];
            lbDescriptionValue.Text = list[5];
        }

        public ucTeacherInfo()
        {
            InitializeComponent();
            _obj = this;
        }

        private void ucTeacherInfo_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                int id = frmTeacherMain.ID;
                List<string> list = new List<string>();
                list = infoBUS.GetInfoTeacher(id);
                lbNameValue.Text = list[0];
                lbGenderValue.Text = list[1];
                DateTime dateBirth = Convert.ToDateTime(list[2]);
                lbDateBirthValue.Text = dateBirth.ToShortDateString();
                lbPhoneValue.Text = list[3];
                lbAddressValue.Text = list[4];
                lbDescriptionValue.Text = list[5];
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucEditTeacher1"))
            {
                ucEditTeacher1 uc = new ucEditTeacher1(lbPhoneValue.Text, lbAddressValue.Text, lbDescriptionValue.Text);
                uc.Dock = DockStyle.Fill;
                frmTeacherMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmTeacherMain.Instance.PnContainer.Controls["ucEditTeacher1"].BringToFront();
        }
    }
}
