namespace TrungTamAnhVan
{
    partial class ucStudentSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStudentSchedule));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnStudents = new System.Windows.Forms.Panel();
            this.ptbCourse = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.pnStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(37, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(156, 47);
            this.lbTitle.TabIndex = 25;
            this.lbTitle.Text = "Lịch học";
            // 
            // pnStudents
            // 
            this.pnStudents.BackColor = System.Drawing.Color.White;
            this.pnStudents.Controls.Add(this.ptbCourse);
            this.pnStudents.Controls.Add(this.lbTime);
            this.pnStudents.Controls.Add(this.lbClass);
            this.pnStudents.Location = new System.Drawing.Point(44, 105);
            this.pnStudents.Name = "pnStudents";
            this.pnStudents.Size = new System.Drawing.Size(568, 166);
            this.pnStudents.TabIndex = 26;
            // 
            // ptbCourse
            // 
            this.ptbCourse.BackColor = System.Drawing.Color.Transparent;
            this.ptbCourse.Image = ((System.Drawing.Image)(resources.GetObject("ptbCourse.Image")));
            this.ptbCourse.Location = new System.Drawing.Point(431, 43);
            this.ptbCourse.Name = "ptbCourse";
            this.ptbCourse.Size = new System.Drawing.Size(104, 85);
            this.ptbCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCourse.TabIndex = 13;
            this.ptbCourse.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(21, 69);
            this.lbTime.MaximumSize = new System.Drawing.Size(400, 900);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(80, 33);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "label2";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.Location = new System.Drawing.Point(18, 11);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(119, 47);
            this.lbClass.TabIndex = 8;
            this.lbClass.Text = "label1";
            // 
            // ucStudentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnStudents);
            this.Controls.Add(this.lbTitle);
            this.Name = "ucStudentSchedule";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucStudentSchedule_Load);
            this.pnStudents.ResumeLayout(false);
            this.pnStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnStudents;
        private System.Windows.Forms.PictureBox ptbCourse;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbClass;
    }
}
