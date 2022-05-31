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
    public partial class ucEditTeacherPassword : UserControl
    {
        InformationBUS infoBUS = new InformationBUS();
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();

        public ucEditTeacherPassword()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                string currentPassword = infoBUS.GetTeacherPassword(frmTeacherMain.ID);

                if (txtCurrentPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy dủ thông tin");
                }
                else if (txtCurrentPassword.Text != currentPassword)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng");
                }
                else if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Mật khẩu không khớp");
                }
                else
                {
                    int teacher_id = frmTeacherMain.ID;
                    string newPassword = txtNewPassword.Text;

                    updateInstance.UpdateTeacherPassword(teacher_id, newPassword);
                    btnCancel.PerformClick();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucEditTeacherPassword"))
            {
                frmTeacherMain.Instance.PnContainer.Controls.RemoveByKey("ucEditTeacherPassword");
            }
        }
    }
}
