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
    public partial class ucAdminStudent : UserControl
    {
        public ucAdminStudent()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(!frmAdminMain.Instance.PnContainer.Controls.ContainsKey("ucInsertStudent"))
            {
                ucInsertStudent uc = new ucInsertStudent();
                uc.Dock = DockStyle.Fill;
                frmAdminMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmAdminMain.Instance.PnContainer.Controls["ucInsertStudent"].BringToFront();
        }
    }
}
