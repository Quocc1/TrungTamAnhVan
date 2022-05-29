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
    public partial class ucClassStudent : UserControl
    {
        static ucClassStudent _obj;
        string className;

        GetInstanceBUS getInstance = new GetInstanceBUS();
        DeleteInstanceBUS deleteInstance = new DeleteInstanceBUS();

        public static ucClassStudent Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucClassStudent("");
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                getInstance.GetAllStudentByClass(dataGridView1, className);
            }
        }

        public ucClassStudent(string className)
        {
            this.className = className;
            _obj = this;
            InitializeComponent();
        }

        private void ucClassStudent_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (dataGridView1.Rows.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }

            if (!DesignMode)
            {
                getInstance.GetAllStudentByClass(dataGridView1, className);
            }
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.GetAllStudentByGenderAndClass(dataGridView1, cboGender.Text, className);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucClassStudent"))
            {
                frmTeacherMain.Instance.PnContainer.Controls.RemoveByKey("ucClassStudent");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucScoreStudent"))
            {
                ucScoreStudent uc = new ucScoreStudent(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                uc.Dock = DockStyle.Fill;
                frmTeacherMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmTeacherMain.Instance.PnContainer.Controls["ucScoreStudent"].BringToFront();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.FindStudentByNameOrPhoneInClass(dataGridView1, txtSearch.Text, className);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (!DesignMode)
            {
                deleteInstance.DeleteStudentFromClass(student_id, 1);
            }
            this.Reload();
        }
    }
}
