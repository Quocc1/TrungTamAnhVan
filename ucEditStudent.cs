using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace TrungTamAnhVan
{
    public partial class ucEditStudent : UserControl
    {
        GetInstanceBUS getInstance = new GetInstanceBUS();
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();

        bool isChecked = false;
        
        int student_id;
        string full_name;
        string gender;
        DateTime date_birth;
        string phone;
        string address;
        string classes;
        string level;

        public ucEditStudent(int student_id, string full_name, string gender, DateTime date_birth, string phone, string address, string classes, string level)
        {
            InitializeComponent();
            this.student_id = student_id;
            this.full_name = full_name;
            this.gender = gender;
            this.date_birth = date_birth;
            this.phone = phone;
            this.address = address;
            this.classes = classes;
            this.level = level;
        }

        private void ucEditStudent_Load(object sender, EventArgs e)
        {
            txtName.Text = full_name;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            dtpDateBirth.Value = date_birth;

            if (gender == "Nam")
            {
                rbtMale.Checked = true;
            }
            else
            {
                rbtFemale.Checked = true;
            }

            if (classes == "Chưa có lớp")
            {
                rbtNotSetClass.Checked = true;
            }

            if (level == "A1")
            {
                cboLevel.SelectedIndex = 0;
            }
            else if (level == "A2")
            {
                cboLevel.SelectedIndex = 1;
            }
            else if (level == "B1")
            {
                cboLevel.SelectedIndex = 2;
            }
            else if (level == "B2")
            {
                cboLevel.SelectedIndex = 3;
            }
            else if (level == "C1")
            {
                cboLevel.SelectedIndex = 4;
            }
            else
            {
                cboLevel.SelectedIndex = 5;
            }

            if (!DesignMode)
            {
                DataGridView _ = new DataGridView();

                cboClass.DisplayMember = "name";
                cboClass.ValueMember = "id";
                getInstance.GetAllClass(_, cboClass, "Lớp còn trống");
            }
        }

        private void rbtNotSetClass_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbtNotSetClass.Checked;
            if (rbtNotSetClass.Checked)
            {
                cboClass.Enabled = false;
                cboClass.SelectedIndex = -1;
            }
            else
            {
                cboClass.Enabled = true;
            }
        }

        private void rbtNotSetClass_Click(object sender, EventArgs e)
        {
            if (rbtNotSetClass.Checked && !isChecked)
            {
                rbtNotSetClass.Checked = false;
            }
            else
            {
                rbtNotSetClass.Checked = true;
                isChecked = false;
            }
        }

        private void cboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboClass.DataSource = null;
            int age = DateTime.Now.Year - date_birth.Year;
            cboClass.DisplayMember = "name";
            cboClass.ValueMember = "id";
            getInstance.GetAllClassByLevelAndCategory(cboClass, cboLevel.SelectedIndex + 1, age);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditStudent"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucEditStudent");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtName.Text == "" || txtAddress.Text == "" || (rbtMale.Checked == false && rbtFemale.Checked == false) || (rbtNotSetClass.Checked == false && cboClass.SelectedIndex < 0))
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");
            }
            else
            {
                if (!DesignMode)
                {
                    int class_id = -1;
                    int level_id = cboLevel.SelectedIndex + 1;
                    string full_name = txtName.Text;
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;
                    string gender = "";

                    if (rbtMale.Checked)
                    {
                        gender = "Nam";
                    }
                    else
                    {
                        gender = "Nữ";
                    }

                    if (!rbtNotSetClass.Checked)
                    {
                        class_id = Convert.ToInt32(cboClass.SelectedValue);
                    }

                    DateTime date_birth = dtpDateBirth.Value;

                    updateInstance.UpdateStudent(student_id, full_name, gender, date_birth, phone, address, class_id, level_id);
                    updateInstance.UpdateClassStudent(student_id, class_id);

                    ucAdminStudent.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }
    }
}
