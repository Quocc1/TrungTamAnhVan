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
    public partial class ucStudentSchedule : UserControl
    {
        static ucStudentSchedule _obj;

        InformationBUS infoBUS = new InformationBUS();

        public static ucStudentSchedule Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucStudentSchedule();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                lbClass.Text = infoBUS.GetClassName(frmStudentMain.ID);
                lbTime.Text = infoBUS.GetTimeClass(lbClass.Text);
            }
        }

        public ucStudentSchedule()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucStudentSchedule_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {

            }

        }
    }
}
