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
    public partial class ucScoreStudent : UserControl
    {
        static ucScoreStudent _obj;
        int student_id;
        GetInstanceBUS getInstance = new GetInstanceBUS();
        
        public static ucScoreStudent Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new ucScoreStudent(0);
                }
                return _obj;
            }
        }

        public void Reload()
        {
            if (!DesignMode)
            {
                getInstance.GetScoreStudent(dataGridView1, student_id);
            }
        }
        
        public ucScoreStudent(int student_id)
        {
            _obj = this;
            this.student_id = student_id;
            InitializeComponent();
        }

        private void ucScoreStudent_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                getInstance.GetScoreStudent(dataGridView1, student_id);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string listening_score = dataGridView1.CurrentRow.Cells[1].Value == null ? "" : dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string speakning_score = dataGridView1.CurrentRow.Cells[2].Value == null ? "" : dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string reading_score = dataGridView1.CurrentRow.Cells[3].Value == null ? "" : dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string writing_score = dataGridView1.CurrentRow.Cells[4].Value == null ? "" : dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (!frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucInsertScore"))
            {
                ucInsertScore uc = new ucInsertScore(student_id, listening_score, speakning_score, reading_score, writing_score);
                uc.Dock = DockStyle.Fill;
                frmTeacherMain.Instance.PnContainer.Controls.Add(uc);
            }
            frmTeacherMain.Instance.PnContainer.Controls["ucInsertScore"].BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucScoreStudent"))
            {
                frmTeacherMain.Instance.PnContainer.Controls.RemoveByKey("ucScoreStudent");
            }
        }
    }
}
