namespace TrungTamAnhVan
{
    partial class ucStudentFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucStudentFee));
            this.pnStudents = new System.Windows.Forms.Panel();
            this.ptbCourse = new System.Windows.Forms.PictureBox();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbFee = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // pnStudents
            // 
            this.pnStudents.BackColor = System.Drawing.Color.White;
            this.pnStudents.Controls.Add(this.ptbCourse);
            this.pnStudents.Controls.Add(this.lbCourse);
            this.pnStudents.Controls.Add(this.lbFee);
            this.pnStudents.Location = new System.Drawing.Point(44, 105);
            this.pnStudents.Name = "pnStudents";
            this.pnStudents.Size = new System.Drawing.Size(568, 166);
            this.pnStudents.TabIndex = 15;
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
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.BackColor = System.Drawing.Color.Transparent;
            this.lbCourse.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourse.Location = new System.Drawing.Point(21, 69);
            this.lbCourse.MaximumSize = new System.Drawing.Size(400, 900);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(80, 33);
            this.lbCourse.TabIndex = 9;
            this.lbCourse.Text = "label2";
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFee.Location = new System.Drawing.Point(18, 11);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(119, 47);
            this.lbFee.TabIndex = 8;
            this.lbFee.Text = "label1";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(37, 33);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(144, 47);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Học Phí";
            // 
            // ucStudentFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnStudents);
            this.Controls.Add(this.lbTitle);
            this.Name = "ucStudentFee";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucStudentFee_Load);
            this.pnStudents.ResumeLayout(false);
            this.pnStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnStudents;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox ptbCourse;
    }
}
