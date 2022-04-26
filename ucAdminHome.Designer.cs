﻿namespace TrungTamAnhVan
{
    partial class ucAdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdminHome));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnStudents = new System.Windows.Forms.Panel();
            this.lbStudentDescription = new System.Windows.Forms.Label();
            this.ptbStudents = new System.Windows.Forms.PictureBox();
            this.lbStudentQuantity = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTeacherDescription = new System.Windows.Forms.Label();
            this.ptbTeachers = new System.Windows.Forms.PictureBox();
            this.lbTeacherQuantity = new System.Windows.Forms.Label();
            this.pnStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudents)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(36, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(189, 47);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Trang Chủ";
            // 
            // pnStudents
            // 
            this.pnStudents.BackColor = System.Drawing.Color.White;
            this.pnStudents.Controls.Add(this.lbStudentDescription);
            this.pnStudents.Controls.Add(this.ptbStudents);
            this.pnStudents.Controls.Add(this.lbStudentQuantity);
            this.pnStudents.Location = new System.Drawing.Point(44, 105);
            this.pnStudents.Name = "pnStudents";
            this.pnStudents.Size = new System.Drawing.Size(323, 125);
            this.pnStudents.TabIndex = 7;
            // 
            // lbStudentDescription
            // 
            this.lbStudentDescription.AutoSize = true;
            this.lbStudentDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbStudentDescription.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentDescription.Location = new System.Drawing.Point(21, 69);
            this.lbStudentDescription.Name = "lbStudentDescription";
            this.lbStudentDescription.Size = new System.Drawing.Size(211, 33);
            this.lbStudentDescription.TabIndex = 9;
            this.lbStudentDescription.Text = "Số lượng học viên";
            // 
            // ptbStudents
            // 
            this.ptbStudents.BackColor = System.Drawing.Color.Transparent;
            this.ptbStudents.Image = ((System.Drawing.Image)(resources.GetObject("ptbStudents.Image")));
            this.ptbStudents.Location = new System.Drawing.Point(214, 25);
            this.ptbStudents.Name = "ptbStudents";
            this.ptbStudents.Size = new System.Drawing.Size(106, 65);
            this.ptbStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbStudents.TabIndex = 11;
            this.ptbStudents.TabStop = false;
            // 
            // lbStudentQuantity
            // 
            this.lbStudentQuantity.AutoSize = true;
            this.lbStudentQuantity.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentQuantity.Location = new System.Drawing.Point(18, 11);
            this.lbStudentQuantity.Name = "lbStudentQuantity";
            this.lbStudentQuantity.Size = new System.Drawing.Size(119, 47);
            this.lbStudentQuantity.TabIndex = 8;
            this.lbStudentQuantity.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbTeacherDescription);
            this.panel1.Controls.Add(this.ptbTeachers);
            this.panel1.Controls.Add(this.lbTeacherQuantity);
            this.panel1.Location = new System.Drawing.Point(603, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 125);
            this.panel1.TabIndex = 10;
            // 
            // lbTeacherDescription
            // 
            this.lbTeacherDescription.AutoSize = true;
            this.lbTeacherDescription.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherDescription.Location = new System.Drawing.Point(21, 69);
            this.lbTeacherDescription.Name = "lbTeacherDescription";
            this.lbTeacherDescription.Size = new System.Drawing.Size(217, 33);
            this.lbTeacherDescription.TabIndex = 9;
            this.lbTeacherDescription.Text = "Số lượng giáo viên";
            // 
            // ptbTeachers
            // 
            this.ptbTeachers.BackColor = System.Drawing.Color.Transparent;
            this.ptbTeachers.Image = ((System.Drawing.Image)(resources.GetObject("ptbTeachers.Image")));
            this.ptbTeachers.Location = new System.Drawing.Point(214, 25);
            this.ptbTeachers.Name = "ptbTeachers";
            this.ptbTeachers.Size = new System.Drawing.Size(106, 65);
            this.ptbTeachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTeachers.TabIndex = 12;
            this.ptbTeachers.TabStop = false;
            // 
            // lbTeacherQuantity
            // 
            this.lbTeacherQuantity.AutoSize = true;
            this.lbTeacherQuantity.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacherQuantity.Location = new System.Drawing.Point(18, 11);
            this.lbTeacherQuantity.Name = "lbTeacherQuantity";
            this.lbTeacherQuantity.Size = new System.Drawing.Size(119, 47);
            this.lbTeacherQuantity.TabIndex = 8;
            this.lbTeacherQuantity.Text = "label1";
            // 
            // ucAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnStudents);
            this.Controls.Add(this.lbTitle);
            this.Name = "ucAdminHome";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucAdminHome_Load);
            this.pnStudents.ResumeLayout(false);
            this.pnStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnStudents;
        private System.Windows.Forms.Label lbStudentDescription;
        private System.Windows.Forms.Label lbStudentQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTeacherDescription;
        private System.Windows.Forms.Label lbTeacherQuantity;
        private System.Windows.Forms.PictureBox ptbStudents;
        private System.Windows.Forms.PictureBox ptbTeachers;
    }
}