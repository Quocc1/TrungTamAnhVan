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
    public partial class ucEditCourse : UserControl
    {
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();
        int id;

        public ucEditCourse(int id)
        {
            InitializeComponent();
            
            this.id = id;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtLessons.Text == "" || txtDescription.Text == "" || txtTerm.Text == "" || cboCategory.SelectedIndex < 0 || cboLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");
            }
            else
            {
                if (!DesignMode)
                {
                    int lessons = Convert.ToInt32(txtLessons.Text);
                    string description = txtDescription.Text;
                    string term = $"{txtTerm.Text} tháng";
                    int level_id = cboLevel.SelectedIndex + 1;
                    int category_id = cboCategory.SelectedIndex + 1;

                    updateInstance.UpdateCourse(id, lessons, description, term, level_id, category_id);
                    ucAdminCourse.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditCourse"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucEditCourse");
            }
        }
    }
}
