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
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (!DesignMode)
                {
                    deleteInstance.DeleteStudentAccount(id);
                    deleteInstance.DeleteStudent(id);
                }
                this.Reload();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //int id = dataGridView1.CurrentRow.Cells[0].Value;
            //string full_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //string id = dataGridView1.CurrentRow.Cells[2].Value;
            //int id = dataGridView1.CurrentRow.Cells[3].Value;
            //int id = dataGridView1.CurrentRow.Cells[4].Value;
            //string address = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //int class_id = dataGridView1.CurrentRow.Cells[6].Value;
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
    }
}
