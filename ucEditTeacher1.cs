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
    public partial class ucEditTeacher1 : UserControl
    {
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();

        string phone;
        string address;
        string description;

        public ucEditTeacher1(string phone, string address, string description)
        {
            InitializeComponent();
            this.phone = phone;
            this.address = address;
            this.description = description;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucEditTeacher1"))
            {
                frmTeacherMain.Instance.PnContainer.Controls.RemoveByKey("ucEditTeacher1");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtAddress.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");
            }
            else
            {
                if (!DesignMode)
                {
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    string description = txtDescription.Text;

                    updateInstance.UpdateTeacherInfo(frmTeacherMain.ID, phone, address, description);
                    ucTeacherInfo.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }

        private void ucEditTeacher1_Load(object sender, EventArgs e)
        {
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtDescription.Text = description;
        }
    }
}
