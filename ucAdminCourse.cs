using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrungTamAnhVan
{
    public partial class ucAdminCourse : UserControl
    {
        public ucAdminCourse()
        {
            InitializeComponent();
        }

        private void ucAdminCourse_Load(object sender, EventArgs e)
        {
            cboLevel.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;

            //dataGridView1.DataSource = 
        }
    }
}
