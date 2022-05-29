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
    public partial class ucInsertEvent : UserControl
    {
        GetInstanceBUS getInstance = new GetInstanceBUS();
        AddInstanceBUS addInstance = new AddInstanceBUS();

        bool isChecked = false;

        public ucInsertEvent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucInsertEvent"))
            {
                frmTeacherMain.Instance.PnContainer.Controls.RemoveByKey("ucInsertEvent");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");

            }
            else
            {
                if (!DesignMode)
                {
                    if (rbtAllClass.Checked == false)
                    {
                        string title = txtTitle.Text;
                        string description = txtDescription.Text;
                        DateTime sending_time = DateTime.Now;
                        int class_id = Convert.ToInt32(cboClass.SelectedValue);
                        addInstance.AddEvent(title, description, sending_time, class_id);
                    }
                    else
                    {
                        foreach (var item in cboClass.Items)
                        {
                            var dict = item.GetType().GetProperties().ToDictionary(x => x.Name, x => x.GetValue(item, null));
                            int class_id = Convert.ToInt32(dict["id"]);
                            addInstance.AddEvent(txtTitle.Text, txtDescription.Text, DateTime.Now, class_id);
                        }
                    }
                    btnCancel.PerformClick();
                }
            }
            
            
        }

        private void rbtAllClass_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbtAllClass.Checked;
            if (rbtAllClass.Checked)
            {
                cboClass.Enabled = false;
                cboClass.SelectedIndex = -1;
            }
            else
            {
                cboClass.Enabled = true;
            }
        }

        private void rbtAllClass_Click(object sender, EventArgs e)
        {
            if (rbtAllClass.Checked && !isChecked)
            {
                rbtAllClass.Checked = false;
            }
            else
            {
                rbtAllClass.Checked = true;
                isChecked = false;
            }
        }

        private void ucInsertEvent_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                DataGridView _ = new DataGridView();

                cboClass.DisplayMember = "name";
                cboClass.ValueMember = "id";
                getInstance.GetAllClassInCharge(_, cboClass, frmTeacherMain.ID);
            }
        }
    }
}
