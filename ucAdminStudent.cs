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
        InstanceBUS instanceBUS = new InstanceBUS();
        public ucAdminStudent()
        {
            InitializeComponent();
        }

        private void ucAdminStudent_Load(object sender, EventArgs e)
        {
            cboClass.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;

            instanceBUS.GetAllStudent(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Năm sinh";
            dataGridView1.Columns[4].HeaderText = "SĐT";
            dataGridView1.Columns[5].HeaderText = "Địa chỉ";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

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
    }
}
