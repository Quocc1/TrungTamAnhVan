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
    public partial class ucInsertClass : UserControl
    {
        InformationBUS infoBUS = new InformationBUS();
        GetInstanceBUS getInstance = new GetInstanceBUS();
        AddInstanceBUS addInstance = new AddInstanceBUS();
        public ucInsertClass()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertClass"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucInsertClass");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || cboCourse.SelectedIndex < 0 || cboTeacher.SelectedIndex < 0 || (chkMonday.Checked == false && chkTuesday.Checked == false && chkWednesday.Checked == false && chkThursday.Checked == false && chkFriday.Checked == false && chkSunday.Checked == false) || txtTimeStart.Text == "" || txtTimeEnd.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");
            }
            else
            {
                if (!DesignMode)
                {
                    string name = txtName.Text;
                    string start_day = dtpStartDay.Value.ToShortDateString();
                    string end_day = dtpEndDay.Value.ToShortDateString();
                    int price = Int32.Parse(txtPrice.Text);
                    int teacher_id = Convert.ToInt32(cboTeacher.SelectedValue.ToString());
                    int course_id = Convert.ToInt32(cboCourse.SelectedValue.ToString());
                    string time = ($"{txtTimeStart.Text}h - {txtTimeEnd}h");

                    List<int> listWeekday = new List<int>();
                    if (chkMonday.Checked)
                    {
                        listWeekday.Add(1);
                    }
                    if (chkTuesday.Checked)
                    {
                        listWeekday.Add(2);
                    }
                    if (chkWednesday.Checked)
                    {
                        listWeekday.Add(3);
                    }
                    if (chkThursday.Checked)
                    {
                        listWeekday.Add(4);
                    }
                    if (chkFriday.Checked)
                    {
                        listWeekday.Add(5);
                    }
                    if (chkSaturday.Checked)
                    {
                        listWeekday.Add(6);
                    }
                    if (chkSunday.Checked)
                    {
                        listWeekday.Add(7);
                    }

                    if (!DesignMode)
                    {
                        addInstance.AddClass(name, start_day, end_day, price, teacher_id, course_id);
                        int class_id = infoBUS.GetNewestClassId();
                        addInstance.AddClassWeekday(class_id, listWeekday, time);
                    }

                    ucAdminClass.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }

        private void ucInsertClass_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataGridView _ = new DataGridView();
                cboCourse.DisplayMember = "description";
                cboCourse.ValueMember = "id";
                getInstance.GetAllCourse(_, cboCourse);

                cboTeacher.DisplayMember = "full_name";
                cboTeacher.ValueMember = "id";
                getInstance.GetAllTeacher(_, cboTeacher);
            }
        }

        private void dtpStartDay_ValueChanged(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                int course_id = Convert.ToInt32(cboCourse.SelectedValue.ToString());
                int month = infoBUS.GetTermCourse(course_id);
                dtpEndDay.Value = dtpStartDay.Value.AddMonths(month);
            }
        }
    }
}
