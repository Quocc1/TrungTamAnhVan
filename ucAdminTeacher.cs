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
            }
        }

        public ucAdminTeacher()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucAdminTeacher_Load(object sender, EventArgs e)
        {
            cboGender.SelectedIndex = 0;

            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();
                getInstance.GetAllTeacher(dataGridView1, _);
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
                deleteInstance.DeleteTeacher(id);
            }
            this.Reload();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.GetAllTeacherByGender(dataGridView1, cboGender.Text);
            }
        }
    }
}
