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
    public partial class ucEditClass : UserControl
    {
        InformationBUS infoBUS = new InformationBUS();
        AddInstanceBUS addInstance = new AddInstanceBUS();
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();
        DeleteInstanceBUS deleteInstance = new DeleteInstanceBUS();
        GetInstanceBUS getInstance = new GetInstanceBUS();

        int id;
        string name;
        DateTime start_day;
        DateTime end_day;
        int start_hour;
        int end_hour;
        int price;
        string teacher;
        string course;
        List<int> weekday;

        public ucEditClass(int id, string name, DateTime start_day, DateTime end_day, int start_hour, int end_hour, int price, string teacher, string course, List<int> weekday)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.start_day = start_day;
            this.end_day = end_day;
            this.start_hour = start_hour;
            this.end_hour = end_hour;
            this.price = price;
            this.teacher = teacher;
            this.course = course;
            this.weekday = weekday;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucEditClass"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucEditClass");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                    DateTime start_day = dtpStartDay.Value;
                    DateTime end_day = dtpEndDay.Value;
                    int start_hour = Convert.ToInt32(txtTimeStart.Text); ;
                    int end_hour = Convert.ToInt32(txtTimeEnd.Text);
                    int price = Int32.Parse(txtPrice.Text);
                    int teacher_id = Convert.ToInt32(cboTeacher.SelectedValue.ToString());
                    int course_id = Convert.ToInt32(cboCourse.SelectedValue.ToString());

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
                        string result = infoBUS.CheckAvailableTeacher(id, teacher_id, listWeekday, start_day, end_day, start_hour, end_hour);
                        if (result != "")
                        {
                            MessageBox.Show(result);
                        }
                        else
                        {
                            updateInstance.UpdateClass(id, name, start_day, end_day, price, teacher_id, course_id);
                            deleteInstance.DeleteClassWeekday(id);
                            addInstance.AddClassWeekday(id, listWeekday, start_hour, end_hour);

                            ucAdminClass.Instance.Reload();
                            ucAdminTeacher.Instance.Reload();
                            btnCancel.PerformClick();
                        }
                    }
                }
            }
        }

        private void ucEditClass_Load(object sender, EventArgs e)
        {
            txtName.Text = name;
            dtpStartDay.Value = start_day;
            dtpEndDay.Value = end_day;
            txtTimeStart.Text = start_hour.ToString();
            txtTimeEnd.Text = end_hour.ToString();
            txtPrice.Text = price.ToString();
            
            foreach (var wd in weekday)
            {
                if (wd == 1)
                {
                    chkMonday.Checked = true;
                }
                if (wd == 2)
                {
                    chkTuesday.Checked = true;
                }
                if (wd == 3)
                {
                    chkWednesday.Checked = true;
                }
                if (wd == 4)
                {
                    chkThursday.Checked = true;
                }
                if (wd == 5)
                {
                    chkFriday.Checked = true;
                }
                if (wd == 6)
                {
                    chkSaturday.Checked = true;
                }
                if (wd == 7)
                {
                    chkSunday.Checked = true;
                }
            }

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
    }
}
