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
        GetInstanceBUS getInstance = new GetInstanceBUS();

        int id;
        string name;
        string term;
        int lessons;
        string level;
        string category;

        public ucEditCourse(int id, string name, string term, int lessons, string level, string category)
        {
            InitializeComponent();
            
            this.id = id;
            this.name = name;
            this.term = term;
            this.lessons = lessons;
            this.level = level;
            this.category = category;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtLessons.Text == "" || txtDescription.Text == "" || txtTerm.Text == "")
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

        private void ucEditCourse_Load(object sender, EventArgs e)
        {
            cboLevel.DisplayMember = "sign";
            cboLevel.ValueMember = "id";
            getInstance.GetAllLevel(cboLevel);
            
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "id";
            getInstance.GetAllCategory(cboCategory);

            txtDescription.Text = name;
            txtTerm.Text = term.Substring(0,1);
            txtLessons.Text = lessons.ToString();

            if (level == "A1")
            {
                cboLevel.SelectedIndex = 0;
            }
            else if (level == "A2")
            {
                cboLevel.SelectedIndex = 1;
            }
            else if (level == "B1")
            {
                cboLevel.SelectedIndex = 2;
            }
            else if (level == "B2")
            {
                cboLevel.SelectedIndex = 3;
            }
            else if (level == "C1")
            {
                cboLevel.SelectedIndex = 4;
            }
            else
            {
                cboLevel.SelectedIndex = 5;
            }

            if (category == "Trẻ em")
            {
                cboCategory.SelectedIndex = 0;
            }
            else if (category == "Thanh niên")
            {
                cboCategory.SelectedIndex = 1;
            }
            else
            {
                cboCategory.SelectedIndex = 2;
            }
        }
    }
}
