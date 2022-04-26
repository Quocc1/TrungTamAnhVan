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
    public partial class ucAdminHome : UserControl
    {
        InformationBUS infoBUS = new InformationBUS();
        public ucAdminHome()
        {
            InitializeComponent();
        }

        private void ucAdminHome_Load(object sender, EventArgs e)
        {
            lbStudentQuantity.Text = infoBUS.CountStudent();
            lbTeacherQuantity.Text = infoBUS.CountTeacher();
        }
    }
}
