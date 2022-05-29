namespace TrungTamAnhVan
{
    partial class ucTeacherHome
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
            this.pnDescription = new System.Windows.Forms.Panel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDescription
            // 
            this.pnDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDescription.Controls.Add(this.lbDescription);
            this.pnDescription.Location = new System.Drawing.Point(43, 531);
            this.pnDescription.Name = "pnDescription";
            this.pnDescription.Size = new System.Drawing.Size(906, 189);
            this.pnDescription.TabIndex = 26;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(15, 14);
            this.lbDescription.MaximumSize = new System.Drawing.Size(906, 189);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(21, 33);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = " ";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(40, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(407, 47);
            this.lbTitle.TabIndex = 25;
            this.lbTitle.Text = "Các Thông Báo Gần Đây";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Classs,
            this.Time,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(43, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 383);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Tiêu đề";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Classs
            // 
            this.Classs.DataPropertyName = "classes";
            this.Classs.HeaderText = "Gửi đến lớp";
            this.Classs.MinimumWidth = 6;
            this.Classs.Name = "Classs";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "time";
            this.Time.HeaderText = "Thời điểm gửi";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "description";
            this.Description.FillWeight = 2F;
            this.Description.HeaderText = "Nội dung";
            this.Description.MinimumWidth = 2;
            this.Description.Name = "Description";
            this.Description.Visible = false;
            // 
            // ucTeacherHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDescription);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucTeacherHome";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucTeacherHome_Load);
            this.pnDescription.ResumeLayout(false);
            this.pnDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
