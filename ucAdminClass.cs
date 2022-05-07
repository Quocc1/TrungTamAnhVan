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
    public partial class ucAdminClass : UserControl
    {
        static ucAdminClass _obj;
        GetInstanceBUS getInstance = new GetInstanceBUS();
        DeleteInstanceBUS deleteInstance = new DeleteInstanceBUS();

        public static ucAdminClass Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucAdminClass();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllClass(dataGridView1, _, "Tất cả");
            }
        }

        public ucAdminClass()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucAdminClass_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            cboClassStatus.SelectedIndex = 0;

            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllClass(dataGridView1, _, "Tất cả");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertClass"))
            {
                ucInsertClass uc = new ucInsertClass();
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucAdminClass"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucAdminClass");
            }
            frmAdminMain.Instance.PnContainer.Controls["ucInsertClass"].BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (!DesignMode)
            {
                deleteInstance.DeleteClass(id);
            }
            this.Reload();
        }

        private void cboClassStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllClass(dataGridView1, _, cboClassStatus.Text);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (!DesignMode)
                {
                    getInstance.FindClassByNameOrTeacher(dataGridView1, txtSearch.Text.ToLower().Trim());
                }
            }
            else
            {
                this.Reload();
            }
        }
    }
}
