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
    public partial class ucInsertStudent : UserControl
    {
        InformationBUS infoBUS = new InformationBUS();
        GetInstanceBUS getInstance = new GetInstanceBUS();
        AddInstanceBUS addInstance = new AddInstanceBUS();

        bool isChecked = false;

        public ucInsertStudent()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
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

                    addInstance.AddStudent(full_name, gender, date_birth, phone, address, level_id);
                    
                    int student_id = infoBUS.GetNewestStudentId();
                    string login = ($"student{student_id}");
                    string password = student_id.ToString();

                    addInstance.AddStudentAccount(student_id, login, password);
                    addInstance.AddStudentToClass(student_id, class_id);
                    addInstance.AddStudentScore(student_id);

                    ucAdminStudent.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertStudent"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucInsertStudent");
            }
        }

        private void ucInsertStudent_Load(object sender, EventArgs e)
        {
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
            int age = DateTime.Now.Year - dtpDateBirth.Value.Year;
            cboClass.DisplayMember = "name";
            cboClass.ValueMember = "id";
            getInstance.GetAllClassByLevelAndCategory(cboClass, cboLevel.SelectedIndex + 1, age);
        }
    }
}
