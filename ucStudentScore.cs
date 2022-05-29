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
    public partial class ucStudentScore : UserControl
    {
        static ucStudentScore _obj;
        GetInstanceBUS getInstance = new GetInstanceBUS();

        public static ucStudentScore Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucStudentScore();
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                getInstance.GetScoreStudent(dataGridView1, frmStudentMain.ID);
            }
        }

        public ucStudentScore()
        {
            _obj = this;
            InitializeComponent();
        }

        private void ucStudentScore_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.GetScoreStudent(dataGridView1, frmStudentMain.ID);
            }
        }
    }
}
