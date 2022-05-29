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
    public partial class ucStudentFee : UserControl
    {
        static ucStudentFee _obj;

        InformationBUS infoBUS = new InformationBUS();
        public static ucStudentFee Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucStudentFee();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                lbFee.Text = infoBUS.GetClassPrice(frmStudentMain.ID).ToString() + " Đồng";
                lbCourse.Text = infoBUS.GetCourseName(frmStudentMain.ID);
            }
        }

        public ucStudentFee()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucStudentFee_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                lbFee.Text = infoBUS.GetClassPrice(frmStudentMain.ID).ToString() + " Đồng";
                lbCourse.Text = infoBUS.GetCourseName(frmStudentMain.ID);
            }
        }
    }
}
