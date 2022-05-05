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

        public ucInsertStudent()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtName.Text == "" || txtAddress.Text == "" || cboClass.SelectedIndex < 0 || (rbtMale.Checked == false && rbtFemale.Checked == false))
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
                    string gender = "";
                    if (rbtMale.Checked)
                    {
                        gender = "Nam";
                    }
                    else
                    {
                        gender = "Nu";
                    }
                    int class_id = Convert.ToInt32(cboClass.SelectedValue.ToString());
                    string date_birth = dtpBirthDate.Value.ToShortDateString();

                    addInstance.AddStudent(full_name, gender, date_birth, phone, address, class_id);
                    
                    int id = infoBUS.GetNewestStudentId();
                    string login = ($"student{id}");
                    string password = id.ToString();
                    addInstance.AddStudentAccount(id, login, password);
                    
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
    }
}
