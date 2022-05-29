namespace TrungTamAnhVan
{
    partial class ucInsertCourse
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
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbTerm = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtLessons = new System.Windows.Forms.TextBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbLesson = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(90, 286);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(94, 40);
            this.lbDescription.TabIndex = 0;
            this.lbDescription.Text = "Mô tả";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(90, 140);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(153, 40);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Đối tượng";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(90, 60);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(110, 40);
            this.lbLevel.TabIndex = 2;
            this.lbLevel.Text = "Cấp độ";
            // 
            // lbTerm
            // 
            this.lbTerm.AutoSize = true;
            this.lbTerm.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTerm.Location = new System.Drawing.Point(538, 60);
            this.lbTerm.Name = "lbTerm";
            this.lbTerm.Size = new System.Drawing.Size(109, 40);
            this.lbTerm.TabIndex = 3;
            this.lbTerm.Text = "Kỳ hạn";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(538, 140);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(136, 40);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Số lượng";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(97, 345);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(681, 196);
            this.txtDescription.TabIndex = 5;
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
            this.cboLevel.Location = new System.Drawing.Point(236, 74);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(121, 24);
            this.cboLevel.TabIndex = 20;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Trẻ em",
            "Thanh niên",
            "Người lớn"});
            this.cboCategory.Location = new System.Drawing.Point(236, 154);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 24);
            this.cboCategory.TabIndex = 21;
            // 
            // txtTerm
            // 
            this.txtTerm.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.Location = new System.Drawing.Point(678, 61);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 39);
            this.txtTerm.TabIndex = 22;
            // 
            // txtLessons
            // 
            this.txtLessons.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLessons.Location = new System.Drawing.Point(678, 141);
            this.txtLessons.Name = "txtLessons";
            this.txtLessons.Size = new System.Drawing.Size(100, 39);
            this.txtLessons.TabIndex = 23;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(793, 60);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(101, 40);
            this.lbMonth.TabIndex = 24;
            this.lbMonth.Text = "Tháng";
            // 
            // lbLesson
            // 
            this.lbLesson.AutoSize = true;
            this.lbLesson.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLesson.Location = new System.Drawing.Point(793, 140);
            this.lbLesson.Name = "lbLesson";
            this.lbLesson.Size = new System.Drawing.Size(115, 40);
            this.lbLesson.TabIndex = 25;
            this.lbLesson.Text = "Bài học";
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
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucInsertCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLesson);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.txtLessons);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboLevel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbTerm);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbDescription);
            this.Name = "ucInsertCourse";
            this.Size = new System.Drawing.Size(989, 754);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbTerm;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtLessons;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbLesson;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
    }
}
