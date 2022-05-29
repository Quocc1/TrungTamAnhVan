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
    public partial class ucEditTeacher : UserControl
    {
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();

        int id;
        string full_name;
        string gender;
        DateTime date_birth;
        string phone;
        string address;
        string description;

        public ucEditTeacher(int id, string full_name, string gender, DateTime date_birth, string phone, string address, string description)
        {
            InitializeComponent();
            this.id = id;
            this.full_name = full_name;
            this.gender = gender;
            this.date_birth = date_birth;
            this.phone = phone;
            this.address = address;
            this.description = description;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditTeacher"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucEditTeacher");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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

                    updateInstance.UpdateTeacher(id, full_name, gender, date_birth, phone, address, description);
                    ucAdminTeacher.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }

        private void ucEditTeacher_Load(object sender, EventArgs e)
        {
            txtName.Text = full_name;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtDescription.Text = description;
            dtpDateBirth.Value = date_birth;
            if(gender == "Nam")
            {
                rbtMale.Checked = true;
            }
            else
            {
                rbtFemale.Checked = true;
            }
        }
    }
}
