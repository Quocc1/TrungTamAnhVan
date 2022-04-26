namespace TrungTamAnhVan
{
    partial class frmAdminMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMain));
            this.pnContainer = new System.Windows.Forms.Panel();
            this.ucAdminHome1 = new TrungTamAnhVan.ucAdminHome();
            this.ucAdminStudent1 = new TrungTamAnhVan.ucAdminStudent();
            this.ptbHomeLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnFinance = new System.Windows.Forms.Button();
            this.pnNavbar = new System.Windows.Forms.Panel();
            this.pnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.pnNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.ucAdminHome1);
            this.pnContainer.Controls.Add(this.ucAdminStudent1);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(273, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(989, 754);
            this.pnContainer.TabIndex = 1;
            // 
            // ucAdminHome1
            // 
            this.ucAdminHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminHome1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminHome1.Name = "ucAdminHome1";
            this.ucAdminHome1.Size = new System.Drawing.Size(989, 754);
            this.ucAdminHome1.TabIndex = 1;
            // 
            // ucAdminStudent1
            // 
            this.ucAdminStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAdminStudent1.Location = new System.Drawing.Point(0, 0);
            this.ucAdminStudent1.Name = "ucAdminStudent1";
            this.ucAdminStudent1.Size = new System.Drawing.Size(989, 754);
            this.ucAdminStudent1.TabIndex = 0;
            // 
            // ptbHomeLogo
            // 
            this.ptbHomeLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbHomeLogo.Image")));
            this.ptbHomeLogo.Location = new System.Drawing.Point(48, 12);
            this.ptbHomeLogo.Name = "ptbHomeLogo";
            this.ptbHomeLogo.Size = new System.Drawing.Size(164, 95);
            this.ptbHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHomeLogo.TabIndex = 0;
            this.ptbHomeLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(246)))));
            this.btnLogout.Location = new System.Drawing.Point(31, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(207, 41);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(31, 688);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ptbIcon
            // 
            this.ptbIcon.Image = ((System.Drawing.Image)(resources.GetObject("ptbIcon.Image")));
            this.ptbIcon.Location = new System.Drawing.Point(0, 551);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(117, 71);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIcon.TabIndex = 2;
            this.ptbIcon.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(100, 554);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 28);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Tên";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(100, 589);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(131, 28);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Quản trị viên";
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 131);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(273, 62);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(0, 199);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(273, 62);
            this.btnStudent.TabIndex = 6;
            this.btnStudent.Text = "Học viên";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(0, 267);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTeacher.Size = new System.Drawing.Size(273, 62);
            this.btnTeacher.TabIndex = 7;
            this.btnTeacher.Text = "Giáo viên";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnClass
            // 
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.Image")));
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(0, 335);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClass.Size = new System.Drawing.Size(273, 62);
            this.btnClass.TabIndex = 8;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnCourse.Image")));
            this.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourse.Location = new System.Drawing.Point(0, 403);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCourse.Size = new System.Drawing.Size(273, 62);
            this.btnCourse.TabIndex = 9;
            this.btnCourse.Text = "Khóa học";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.FlatAppearance.BorderSize = 0;
            this.btnFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinance.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.Image = ((System.Drawing.Image)(resources.GetObject("btnFinance.Image")));
            this.btnFinance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinance.Location = new System.Drawing.Point(0, 471);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFinance.Size = new System.Drawing.Size(273, 62);
            this.btnFinance.TabIndex = 10;
            this.btnFinance.Text = "Tài chính";
            this.btnFinance.UseVisualStyleBackColor = true;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // pnNavbar
            // 
            this.pnNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(246)))));
            this.pnNavbar.Controls.Add(this.btnFinance);
            this.pnNavbar.Controls.Add(this.btnCourse);
            this.pnNavbar.Controls.Add(this.btnClass);
            this.pnNavbar.Controls.Add(this.btnTeacher);
            this.pnNavbar.Controls.Add(this.btnStudent);
            this.pnNavbar.Controls.Add(this.btnHome);
            this.pnNavbar.Controls.Add(this.lbRole);
            this.pnNavbar.Controls.Add(this.lbName);
            this.pnNavbar.Controls.Add(this.ptbIcon);
            this.pnNavbar.Controls.Add(this.btnExit);
            this.pnNavbar.Controls.Add(this.btnLogout);
            this.pnNavbar.Controls.Add(this.ptbHomeLogo);
            this.pnNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnNavbar.Name = "pnNavbar";
            this.pnNavbar.Size = new System.Drawing.Size(273, 754);
            this.pnNavbar.TabIndex = 0;
            // 
            // frmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 754);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.pnNavbar.ResumeLayout(false);
            this.pnNavbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.PictureBox ptbHomeLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Panel pnNavbar;
        private ucAdminStudent ucAdminStudent1;
        private ucAdminHome ucAdminHome1;
    }
}

