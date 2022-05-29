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
    public partial class ucAdminTeacher : UserControl
    {
        static ucAdminTeacher _obj;
        GetInstanceBUS getInstance = new GetInstanceBUS();
        DeleteInstanceBUS deleteInstance = new DeleteInstanceBUS();
        InformationBUS infoBUS = new InformationBUS();

        public static ucAdminTeacher Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucAdminTeacher();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllTeacher(dataGridView1, _);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int teacher_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    infoBUS.GetTeacherSalary(teacher_id);
                }
            }
        }

        public ucAdminTeacher()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucAdminTeacher_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            cboGender.SelectedIndex = 0;

            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllTeacher(dataGridView1, _);

                for (int i = 0; i < dataGridView1.Rows.Count; i ++)
                {
                    int teacher_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    infoBUS.GetTeacherSalary(teacher_id);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertTeacher"))
            {
                ucInsertTeacher uc = new ucInsertTeacher();
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucInsertTeacher"].BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (!DesignMode)
            {
                deleteInstance.DeleteTeacherAccount(id);
                deleteInstance.DeleteTeacherInClass(id);
                deleteInstance.DeleteTeacher(id);
            }
            this.Reload();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (!DesignMode)
            {
                getInstance.GetAllTeacherByGender(dataGridView1, cboGender.Text);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (!DesignMode)
                {
                    getInstance.FindTeacherByNameOrPhone(dataGridView1, txtSearch.Text.ToLower().Trim());
                }
            }
            else
            {
                this.Reload();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string full_name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string gender = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTime date_birth = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            string phone = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string address = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string description = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditTeacher"))
            {
                ucEditTeacher uc = new ucEditTeacher(id, full_name, gender, date_birth, phone, address, description);
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucEditTeacher"].BringToFront();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }
    }
}
