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
    public partial class ucTeacherHome : UserControl
    {
        static ucTeacherHome _obj;

        GetInstanceBUS getInstance = new GetInstanceBUS();

        public static ucTeacherHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucTeacherHome();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                getInstance.GetAllEvent(dataGridView1, "", frmTeacherMain.ID);
            }
        }
        public ucTeacherHome()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucTeacherHome_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            if (!DesignMode)
            {
                getInstance.GetAllEvent(dataGridView1, "", frmTeacherMain.ID);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbDescription.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
