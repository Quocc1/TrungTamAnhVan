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
    public partial class ucTeacherSalary : UserControl
    {
        static ucTeacherSalary _obj;

        InformationBUS infoBUS = new InformationBUS();

        public static ucTeacherSalary Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucTeacherSalary();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                int day = infoBUS.CountTeachingDay(frmTeacherMain.ID);
                lbSalary.Text = (Convert.ToDecimal(day * 200000)).ToString() + " Đồng";
                lbDays.Text = "Số lượng buổi dạy: " + day.ToString() + " buổi";
            }
        }

        public ucTeacherSalary()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucTeacherSalary_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                int day = infoBUS.CountTeachingDay(frmTeacherMain.ID);
                lbSalary.Text = infoBUS.GetTeacherSalary(frmTeacherMain.ID).ToString() + " Đồng";
                lbDays.Text = "Số lượng buổi dạy: " + day.ToString() + " buổi"; ;
            }
        }
    }
}
