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
    public partial class ucEditStudentPassword : UserControl
    {
        InformationBUS infoBUS = new InformationBUS();
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();

        public ucEditStudentPassword()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                string currentPassword = infoBUS.GetStudentPassword(frmStudentMain.ID);

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
                    int student_id = frmStudentMain.ID;
                    string newPassword = txtNewPassword.Text;

                    updateInstance.UpdateStudentPassword(student_id, newPassword);
                    btnCancel.PerformClick();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmStudentMain.Instance.PnContainer.Controls.ContainsKey("ucEditStudentPassword"))
            {
                frmStudentMain.Instance.PnContainer.Controls.RemoveByKey("ucEditStudentPassword");
            }
        }
    }
}
