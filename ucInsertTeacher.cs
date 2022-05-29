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
    public partial class ucInsertTeacher : UserControl
    {
        AddInstanceBUS addInstance = new AddInstanceBUS();
        InformationBUS infoBUS = new InformationBUS();

        public ucInsertTeacher()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtName.Text == "" || txtAddress.Text == "" || txtDescription.Text == "" || (rbtMale.Checked == false && rbtFemale.Checked == false))
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");
            }
            else
            {
                if (!DesignMode)
                {
                    string full_name = txtName.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    string description = txtDescription.Text;
                    string gender = "";
                    if (rbtMale.Checked)
                    {
                        gender = "Nam";
                    }
                    else
                    {
                        gender = "Nữ";
                    }
                    DateTime date_birth = dtpDateBirth.Value;

                    addInstance.AddTeacher(full_name, gender, date_birth, phone, address, description);

                    int id = infoBUS.GetNewestTeacherId();
                    string login = ($"teacher{id}");
                    string password = id.ToString();
                    addInstance.AddTeacherAccount(id, login, password);

                    ucAdminTeacher.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertTeacher"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucInsertTeacher");
            }
        }
    }
}
