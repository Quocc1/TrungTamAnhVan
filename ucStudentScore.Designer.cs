namespace TrungTamAnhVan
{
    partial class ucStudentScore
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.listenScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speakingScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writingScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listenScore,
            this.speakingScore,
            this.readingScore,
            this.writingScore,
            this.avgScore});
            this.dataGridView1.Location = new System.Drawing.Point(46, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 486);
            this.dataGridView1.TabIndex = 22;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(37, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(250, 47);
            this.lbTitle.TabIndex = 23;
            this.lbTitle.Text = "Điểm Của Bạn";
            // 
            // listenScore
            // 
            this.listenScore.DataPropertyName = "listen_score";
            this.listenScore.FillWeight = 118.3991F;
            this.listenScore.HeaderText = "Điểm nghe";
            this.listenScore.MinimumWidth = 6;
            this.listenScore.Name = "listenScore";
            // 
            // speakingScore
            // 
            this.speakingScore.DataPropertyName = "speaking_score";
            this.speakingScore.FillWeight = 118.3991F;
            this.speakingScore.HeaderText = "Điểm nói";
            this.speakingScore.MinimumWidth = 6;
            this.speakingScore.Name = "speakingScore";
            // 
            // readingScore
            // 
            this.readingScore.DataPropertyName = "reading_score";
            this.readingScore.FillWeight = 118.3991F;
            this.readingScore.HeaderText = "Điểm đọc";
            this.readingScore.MinimumWidth = 6;
            this.readingScore.Name = "readingScore";
            // 
            // writingScore
            // 
            this.writingScore.DataPropertyName = "writing_score";
            this.writingScore.FillWeight = 118.3991F;
            this.writingScore.HeaderText = "Điểm viết";
            this.writingScore.MinimumWidth = 6;
            this.writingScore.Name = "writingScore";
            // 
            // avgScore
            // 
            this.avgScore.DataPropertyName = "avg_score";
            this.avgScore.FillWeight = 118.3991F;
            this.avgScore.HeaderText = "Điểm trung bình";
            this.avgScore.MinimumWidth = 6;
            this.avgScore.Name = "avgScore";
            // 
            // ucStudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbTitle);
            this.Name = "ucStudentScore";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucStudentScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn listenScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn speakingScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn writingScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgScore;
    }
}
