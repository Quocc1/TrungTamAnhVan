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

            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditCourse"))
            {
                ucEditCourse uc = new ucEditCourse(id);
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucEditCourse"].BringToFront();
        }
    }
}
