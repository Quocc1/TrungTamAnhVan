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
    public partial class ucAdminStudent : UserControl
    {
        static ucAdminStudent _obj;
        GetInstanceBUS getInstance = new GetInstanceBUS();
        DeleteInstanceBUS deleteInstance = new DeleteInstanceBUS();
        
        public static ucAdminStudent Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucAdminStudent();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            if (!DesignMode)
            {
                getInstance.GetAllStudent(dataGridView1);
            }
        }

        public ucAdminStudent()
        {
            _obj = this;
            InitializeComponent();
        }


        private void ucAdminStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (dataGridView1.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
            }
            cboClass.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            
            if(!DesignMode)
            {
                getInstance.GetAllStudent(dataGridView1);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertStudent"))
            {
                ucInsertStudent uc = new ucInsertStudent();
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucInsertStudent"].BringToFront();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (!DesignMode)
            {
                getInstance.GetAllStudentByGenderAndClass(dataGridView1, cboGender.Text, cboClass.Text);
            }
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (!DesignMode)
            {
                getInstance.GetAllStudentByGenderAndClass(dataGridView1, cboGender.Text, cboClass.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                int student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (!DesignMode)
                {
                    deleteInstance.DeleteStudentAccount(student_id);
                    deleteInstance.DeleteStudentScore(student_id);
                    if (dataGridView1.CurrentRow.Cells[6].ToString() != "Chưa có lớp")
                    {
                        deleteInstance.DeleteStudentFromClass(student_id, 0);
                    }
                    deleteInstance.DeleteStudent(student_id);
                }
                this.Reload();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string full_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTime date_birth = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            string phone = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string address = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string classes = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string level = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditStudent"))
            {
                ucEditStudent uc = new ucEditStudent(student_id, full_name, gender, date_birth, phone, address, classes, level);
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucEditStudent"].BringToFront();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (!DesignMode)
                {
                    getInstance.FindStudentByNameOrPhone(dataGridView1, txtSearch.Text.ToLower().Trim());
                }
            }
            else
            {
                this.Reload();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }
    }
}
