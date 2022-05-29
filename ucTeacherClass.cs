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
    public partial class ucTeacherClass : UserControl
    {
        static ucTeacherClass _obj;
        GetInstanceBUS getInstance = new GetInstanceBUS();

        public static ucTeacherClass Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucTeacherClass();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            dataGridView1.AutoGenerateColumns = false;
            if (dataGridView1.Rows.Count == 0)
            {
                btnEvent.Enabled = false;
            }
            else
            {
                btnEvent.Enabled = true;
            }

            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();

                getInstance.GetAllClassInCharge(dataGridView1, _, frmTeacherMain.ID);
            }
        }

        public ucTeacherClass()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucTeacherClass_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (dataGridView1.Rows.Count == 0)
            {
                btnEvent.Enabled = false;
            }
            else
            {
                btnEvent.Enabled = true;
            }

            if (!DesignMode)
            {
                ComboBox _ = new ComboBox();

                getInstance.GetAllClassInCharge(dataGridView1, _, frmTeacherMain.ID);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string className = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (!frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucClassStudent"))
            {
                ucClassStudent uc = new ucClassStudent(className);
                uc.Dock = DockStyle.Fill;
                frmTeacherMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmTeacherMain.Instance.PnContainer.Controls["ucClassStudent"].BringToFront();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.FindClassInChargeByName(dataGridView1, txtSearch.Text, frmTeacherMain.ID);
            }
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            if (!frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucInsertEvent"))
            {
                ucInsertEvent uc = new ucInsertEvent();
                uc.Dock = DockStyle.Fill;
                frmTeacherMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmTeacherMain.Instance.PnContainer.Controls["ucInsertEvent"].BringToFront();
        }
    }
}
