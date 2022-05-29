namespace TrungTamAnhVan
{
    partial class ucInsertStudent
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtNotSetClass = new System.Windows.Forms.RadioButton();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.pnGender = new System.Windows.Forms.Panel();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.pnGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(689, 145);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 39);
            this.txtPhone.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(286, 593);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 64);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(97, 593);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(156, 64);
            this.btnInsert.TabIndex = 32;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(538, 140);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(69, 40);
            this.lbPhone.TabIndex = 30;
            this.lbPhone.Text = "SĐT";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(538, 60);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(147, 40);
            this.lbBirthDate.TabIndex = 29;
            this.lbBirthDate.Text = "Năm sinh";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(90, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(145, 40);
            this.lbName.TabIndex = 28;
            this.lbName.Text = "Họ và tên";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(90, 140);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(133, 40);
            this.lbGender.TabIndex = 27;
            this.lbGender.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 40);
            this.label1.TabIndex = 39;
            this.label1.Text = "Lớp";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(91, 300);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(109, 40);
            this.lbAddress.TabIndex = 38;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(689, 234);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(200, 24);
            this.cboClass.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(98, 356);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(792, 156);
            this.txtAddress.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(236, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 39);
            this.txtName.TabIndex = 47;
            // 
            // rbtNotSetClass
            // 
            this.rbtNotSetClass.AutoSize = true;
            this.rbtNotSetClass.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNotSetClass.Location = new System.Drawing.Point(689, 264);
            this.rbtNotSetClass.Name = "rbtNotSetClass";
            this.rbtNotSetClass.Size = new System.Drawing.Size(141, 32);
            this.rbtNotSetClass.TabIndex = 48;
            this.rbtNotSetClass.TabStop = true;
            this.rbtNotSetClass.Text = "Xét lớp sau";
            this.rbtNotSetClass.UseVisualStyleBackColor = true;
            this.rbtNotSetClass.CheckedChanged += new System.EventHandler(this.rbtNotSetClass_CheckedChanged);
            this.rbtNotSetClass.Click += new System.EventHandler(this.rbtNotSetClass_Click);
            // 
            // cboLevel
            // 
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "C1",
            "C2"});
            this.cboLevel.Location = new System.Drawing.Point(236, 234);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 24);
            this.cboLevel.TabIndex = 50;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.cboLevel_SelectedIndexChanged);
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(90, 220);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(110, 40);
            this.lbLevel.TabIndex = 49;
            this.lbLevel.Text = "Cấp độ";
            // 
            // pnGender
            // 
            this.pnGender.Controls.Add(this.rbtMale);
            this.pnGender.Controls.Add(this.rbtFemale);
            this.pnGender.Location = new System.Drawing.Point(229, 142);
            this.pnGender.Name = "pnGender";
            this.pnGender.Size = new System.Drawing.Size(229, 56);
            this.pnGender.TabIndex = 52;
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMale.Location = new System.Drawing.Point(7, 3);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(89, 37);
            this.rbtMale.TabIndex = 48;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Nam";
            this.rbtMale.UseVisualStyleBackColor = true;
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFemale.Location = new System.Drawing.Point(143, 3);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(70, 37);
            this.rbtFemale.TabIndex = 47;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Nữ";
            this.rbtFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.CalendarFont = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBirth.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBirth.Location = new System.Drawing.Point(689, 63);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(200, 39);
            this.dtpDateBirth.TabIndex = 53;
            this.dtpDateBirth.Value = new System.DateTime(2022, 5, 13, 0, 0, 0, 0);
            // 
            // ucInsertStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateBirth);
            this.Controls.Add(this.pnGender);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.rbtNotSetClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbGender);
            this.Name = "ucInsertStudent";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucInsertStudent_Load);
            this.pnGender.ResumeLayout(false);
            this.pnGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtNotSetClass;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Panel pnGender;
        private System.Windows.Forms.RadioButton rbtMale;
        private System.Windows.Forms.RadioButton rbtFemale;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
    }
}
