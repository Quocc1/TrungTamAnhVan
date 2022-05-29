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
        InformationBUS infoBUS = new InformationBUS();
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
            frmAdminMain.Instance.PnContainer.Controls["ucInsertClass"].BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (!DesignMode)
            {
                deleteInstance.DeleteClassWeekday(id);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditClass"))
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DateTime start_day = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                DateTime end_day = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                int start_hour = infoBUS.GetStartHour(id);
                int end_hour = infoBUS.GetEndHour(id);
                int price = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                string teacher = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string course = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                List<int> weekday = infoBUS.GetWeekday(id);

                ucEditClass uc = new ucEditClass(id, name, start_day, end_day, start_hour, end_hour, price, teacher, course, weekday);
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucEditClass"].BringToFront();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }
    }
}
