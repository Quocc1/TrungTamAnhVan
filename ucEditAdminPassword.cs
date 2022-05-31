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
    public partial class ucEditAdminPassword : UserControl
    {
        InformationBUS infoBUS = new InformationBUS();
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();

        public ucEditAdminPassword()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                string currentPassword = infoBUS.GetAdminPassword(frmAdminMain.ID);

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
                    int admin_id = frmAdminMain.ID;
                    string newPassword = txtNewPassword.Text;

                    updateInstance.UpdateAdminPassword(admin_id, newPassword);
                    btnCancel.PerformClick();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditAdminPassword"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucEditAdminPassword");
            }
        }
    }
}
