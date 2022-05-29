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
    public partial class ucEditStudent1 : UserControl
    {
        UpdateInstanceBUS updateInstance = new UpdateInstanceBUS();

        string phone;
        string address;

        public ucEditStudent1(string phone, string address)
        {
            InitializeComponent();
            this.phone = phone;
            this.address = address;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmStudentMain.Instance.PnContainer.Controls.ContainsKey("ucEditStudent1"))
            {
                frmStudentMain.Instance.PnContainer.Controls.RemoveByKey("ucEditStudent1");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy dủ thông tin");
            }
            else
            {
                if (!DesignMode)
                {
                    string address = txtAddress.Text;
                    string phone = txtPhone.Text;


                    updateInstance.UpdateStudentInfo(frmStudentMain.ID, phone, address);

                    ucStudentInfo.Instance.Reload();
                    btnCancel.PerformClick();
                }
            }
        }

        private void ucEditStudent1_Load(object sender, EventArgs e)
        {
            txtPhone.Text = this.phone;
            txtAddress.Text = this.address;
        }
    }
}
