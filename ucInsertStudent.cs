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
    public partial class ucInsertStudent : UserControl
    {
        public ucInsertStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertStudent"))
            {
                frmAdminMain.Instance.PnContainer.Controls.RemoveByKey("ucInsertStudent");
            }
        }
    }
}
