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
    public partial class ucAdminCourse : UserControl
    {
        static ucAdminCourse _obj;
        GetInstanceBUS getInstance = new GetInstanceBUS();
        DeleteInstanceBUS deleteInstance = new DeleteInstanceBUS();

        public static ucAdminCourse Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucAdminCourse();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllCourse(dataGridView1, _);
            }
        }

        public ucAdminCourse()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucAdminCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            cboLevel.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;

            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllCourse(dataGridView1, _);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertCourse"))
            {
                ucInsertCourse uc = new ucInsertCourse();
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucInsertCourse"].BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (!DesignMode)
            {
                deleteInstance.DeleteCourse(id);
            }
            this.Reload();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string term = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            int lessons = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            string level = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string category = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditCourse"))
            {
                ucEditCourse uc = new ucEditCourse(id, name, term, lessons, level, category);
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucEditCourse"].BringToFront();
        }

        private void cboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.GetAllCourseByLevelAndCategory(dataGridView1, cboLevel.SelectedIndex, cboCategory.SelectedIndex);
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.GetAllCourseByLevelAndCategory(dataGridView1, cboLevel.SelectedIndex, cboCategory.SelectedIndex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (!DesignMode)
                {
                    getInstance.FindCourseByName(dataGridView1, txtSearch.Text.ToLower().Trim());
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
