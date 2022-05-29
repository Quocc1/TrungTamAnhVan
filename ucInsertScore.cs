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
    public partial class ucInsertScore : UserControl
    {
        int student_id;
        string listening_score;
        string speakning_score;
        string reading_score;
        string writing_score;

        UpdateInstanceBUS updateInstanceBUS = new UpdateInstanceBUS();

        public ucInsertScore(int student_id, string listening_score, string speakning_score, string reading_score, string writing_score)
        {
            this.student_id = student_id;
            this.listening_score = listening_score;
            this.speakning_score = speakning_score;
            this.reading_score = reading_score;
            this.writing_score = writing_score;

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (frmTeacherMain.Instance.PnContainer.Controls.ContainsKey("ucInsertScore"))
            {
                frmTeacherMain.Instance.PnContainer.Controls.RemoveByKey("ucInsertScore");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string listening_score = txtListeningScore.Text;
            string speakning_score = txtSpeakingScore.Text;
            string reading_score = txtReadingScore.Text;
            string writing_score = txtWritingScore.Text;
            updateInstanceBUS.UpdateStudentScore(student_id, listening_score, speakning_score, reading_score, writing_score);

            ucScoreStudent.Instance.Reload();
            btnCancel.PerformClick();
        }

        private void ucInsertScore_Load(object sender, EventArgs e)
        {
            txtListeningScore.Text = listening_score;
            txtSpeakingScore.Text = speakning_score;
            txtReadingScore.Text = reading_score;
            txtWritingScore.Text = writing_score;
        }
    }
}
