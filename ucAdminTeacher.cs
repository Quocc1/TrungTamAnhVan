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
    public partial class ucAdminTeacher : UserControl
    {
        public ucAdminTeacher()
        {
            InitializeComponent();
        }

        private void ucAdminTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertStudent fInsertStudent = new frmInsertStudent();
            fInsertStudent.Show();
        }
    }
}
