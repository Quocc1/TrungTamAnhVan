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
    public partial class ucInsertCourse : UserControl
    {

        AddInstanceBUS addInstance = new AddInstanceBUS();
        public ucInsertCourse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertCourse"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucInsertCourse");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtLessons.Text == "" || txtDescription.Text == "" || txtTerm.Text == "" || cboCategory.SelectedIndex < 0 || cboLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");
            }
            else
            {
                if (!DesignMode)
                {
                    int lessons = Int32.Parse(txtLessons.Text);
                    string description = txtDescription.Text;
                    string term = $"{txtTerm.Text} tháng";
                    int level_id = cboLevel.SelectedIndex + 1;
                    int category_id = cboCategory.SelectedIndex + 1;

                    addInstance.AddCourse(lessons, description, term, level_id, category_id);
                    ucAdminCourse.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }
    }
}
