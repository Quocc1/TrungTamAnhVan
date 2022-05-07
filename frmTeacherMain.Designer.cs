namespace TrungTamAnhVan
{
    partial class frmTeacherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherMain));
            this.pnNavbar = new System.Windows.Forms.Panel();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ptbHomeLogo = new System.Windows.Forms.PictureBox();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomeLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNavbar
            // 
            this.pnNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(86)))), ((int)(((byte)(246)))));
            this.pnNavbar.Controls.Add(this.btnInfo);
            this.pnNavbar.Controls.Add(this.btnSalary);
            this.pnNavbar.Controls.Add(this.btnSchedule);
            this.pnNavbar.Controls.Add(this.btnClass);
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
            this.pnNavbar.TabIndex = 2;
            // 
            // btnSalary
            // 
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.ForeColor = System.Drawing.Color.White;
            this.btnSalary.Image = ((System.Drawing.Image)(resources.GetObject("btnSalary.Image")));
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(0, 403);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(273, 62);
            this.btnSalary.TabIndex = 12;
            this.btnSalary.Text = "Lương";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchedule.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Location = new System.Drawing.Point(0, 335);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(273, 62);
            this.btnSchedule.TabIndex = 10;
            this.btnSchedule.Text = "Lịch biểu";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnClass
            // 
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.White;
            this.btnClass.Image = ((System.Drawing.Image)(resources.GetObject("btnClass.Image")));
            this.btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClass.Location = new System.Drawing.Point(0, 267);
            this.btnClass.Name = "btnClass";
            this.btnClass.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClass.Size = new System.Drawing.Size(273, 62);
            this.btnClass.TabIndex = 8;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
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
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.BackColor = System.Drawing.Color.Transparent;
            this.lbRole.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.White;
            this.lbRole.Location = new System.Drawing.Point(100, 589);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(98, 28);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Giáo viên";
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
            // pnContainer
            // 
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1262, 754);
            this.pnContainer.TabIndex = 3;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 199);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(273, 62);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmTeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 754);
            this.Controls.Add(this.pnNavbar);
            this.Controls.Add(this.pnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeacherMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTeacherMain";
            this.Load += new System.EventHandler(this.frmTeacherMain_Load);
            this.pnNavbar.ResumeLayout(false);
            this.pnNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomeLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnNavbar;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox ptbHomeLogo;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnInfo;
    }
}