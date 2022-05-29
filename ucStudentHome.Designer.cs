namespace TrungTamAnhVan
{
    partial class ucStudentHome
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
            this.pnSetClass = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lbTimeValue = new System.Windows.Forms.Label();
            this.lbLevelValue = new System.Windows.Forms.Label();
            this.lbAgeValue = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbNotifition = new System.Windows.Forms.Label();
            this.pnHome = new System.Windows.Forms.Panel();
            this.pnDescription = new System.Windows.Forms.Panel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnSetClass.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSetClass
            // 
            this.pnSetClass.Controls.Add(this.btnInsert);
            this.pnSetClass.Controls.Add(this.lbTimeValue);
            this.pnSetClass.Controls.Add(this.lbLevelValue);
            this.pnSetClass.Controls.Add(this.lbAgeValue);
            this.pnSetClass.Controls.Add(this.lbTime);
            this.pnSetClass.Controls.Add(this.cboClass);
            this.pnSetClass.Controls.Add(this.lbClass);
            this.pnSetClass.Controls.Add(this.lbLevel);
            this.pnSetClass.Controls.Add(this.lbAge);
            this.pnSetClass.Controls.Add(this.lbNotifition);
            this.pnSetClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSetClass.Location = new System.Drawing.Point(0, 0);
            this.pnSetClass.Name = "pnSetClass";
            this.pnSetClass.Size = new System.Drawing.Size(989, 754);
            this.pnSetClass.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(417, 545);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(156, 64);
            this.btnInsert.TabIndex = 33;
            this.btnInsert.Text = "Hoàn Tất";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbTimeValue
            // 
            this.lbTimeValue.AutoSize = true;
            this.lbTimeValue.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeValue.Location = new System.Drawing.Point(192, 395);
            this.lbTimeValue.Name = "lbTimeValue";
            this.lbTimeValue.Size = new System.Drawing.Size(24, 40);
            this.lbTimeValue.TabIndex = 17;
            this.lbTimeValue.Text = " ";
            // 
            // lbLevelValue
            // 
            this.lbLevelValue.AutoSize = true;
            this.lbLevelValue.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelValue.Location = new System.Drawing.Point(775, 189);
            this.lbLevelValue.Name = "lbLevelValue";
            this.lbLevelValue.Size = new System.Drawing.Size(96, 40);
            this.lbLevelValue.TabIndex = 16;
            this.lbLevelValue.Text = "label2";
            // 
            // lbAgeValue
            // 
            this.lbAgeValue.AutoSize = true;
            this.lbAgeValue.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgeValue.Location = new System.Drawing.Point(238, 189);
            this.lbAgeValue.Name = "lbAgeValue";
            this.lbAgeValue.Size = new System.Drawing.Size(96, 40);
            this.lbAgeValue.TabIndex = 15;
            this.lbAgeValue.Text = "label1";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(43, 395);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(150, 40);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "Thời gian:";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(347, 304);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 24);
            this.cboClass.TabIndex = 13;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(43, 290);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(298, 40);
            this.lbClass.TabIndex = 12;
            this.lbClass.Text = "Lớp học khuyến nghị";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(526, 189);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(252, 40);
            this.lbLevel.TabIndex = 11;
            this.lbLevel.Text = "Trình độ của bạn:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(43, 189);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(197, 40);
            this.lbAge.TabIndex = 10;
            this.lbAge.Text = "Tuổi của bạn:";
            // 
            // lbNotifition
            // 
            this.lbNotifition.AutoSize = true;
            this.lbNotifition.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotifition.Location = new System.Drawing.Point(43, 66);
            this.lbNotifition.Name = "lbNotifition";
            this.lbNotifition.Size = new System.Drawing.Size(903, 40);
            this.lbNotifition.TabIndex = 9;
            this.lbNotifition.Text = "Bạn chưa có lớp, vui lòng chọn lớp phù hợp với trình độ và độ tuổi";
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.pnDescription);
            this.pnHome.Controls.Add(this.lbTitle);
            this.pnHome.Controls.Add(this.dataGridView1);
            this.pnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHome.Location = new System.Drawing.Point(0, 0);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(989, 754);
            this.pnHome.TabIndex = 19;
            // 
            // pnDescription
            // 
            this.pnDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDescription.Controls.Add(this.lbDescription);
            this.pnDescription.Location = new System.Drawing.Point(40, 530);
            this.pnDescription.Name = "pnDescription";
            this.pnDescription.Size = new System.Drawing.Size(906, 189);
            this.pnDescription.TabIndex = 23;
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
            this.lbTitle.Location = new System.Drawing.Point(37, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(407, 47);
            this.lbTitle.TabIndex = 22;
            this.lbTitle.Text = "Các Thông Báo Gần Đây";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Teacher,
            this.Time,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(40, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(906, 383);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Tiêu đề";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Teacher
            // 
            this.Teacher.DataPropertyName = "teacher";
            this.Teacher.HeaderText = "Người gửi";
            this.Teacher.MinimumWidth = 6;
            this.Teacher.Name = "Teacher";
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
            // ucStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnSetClass);
            this.Controls.Add(this.pnHome);
            this.Name = "ucStudentHome";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucStudentHome_Load);
            this.pnSetClass.ResumeLayout(false);
            this.pnSetClass.PerformLayout();
            this.pnHome.ResumeLayout(false);
            this.pnHome.PerformLayout();
            this.pnDescription.ResumeLayout(false);
            this.pnDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSetClass;
        private System.Windows.Forms.Label lbTimeValue;
        private System.Windows.Forms.Label lbLevelValue;
        private System.Windows.Forms.Label lbAgeValue;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbNotifition;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}
