﻿namespace TrungTamAnhVan
{
    partial class ucInsertClass
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbEnđay = new System.Windows.Forms.Label();
            this.lbStartDay = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbWeekday = new System.Windows.Forms.Label();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbTeacher = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.cboTeacher = new System.Windows.Forms.ComboBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(97, 593);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 64);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbEnđay
            // 
            this.lbEnđay.AutoSize = true;
            this.lbEnđay.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnđay.Location = new System.Drawing.Point(538, 140);
            this.lbEnđay.Name = "lbEnđay";
            this.lbEnđay.Size = new System.Drawing.Size(204, 40);
            this.lbEnđay.TabIndex = 28;
            this.lbEnđay.Text = "Ngày kết thúc";
            // 
            // lbStartDay
            // 
            this.lbStartDay.AutoSize = true;
            this.lbStartDay.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDay.Location = new System.Drawing.Point(538, 60);
            this.lbStartDay.Name = "lbStartDay";
            this.lbStartDay.Size = new System.Drawing.Size(196, 40);
            this.lbStartDay.TabIndex = 27;
            this.lbStartDay.Text = "Ngày bắt đầu";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(90, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 40);
            this.lbName.TabIndex = 26;
            this.lbName.Text = "Tên lớp";
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourse.Location = new System.Drawing.Point(90, 140);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(142, 40);
            this.lbCourse.TabIndex = 25;
            this.lbCourse.Text = "Khóa học";
            // 
            // lbWeekday
            // 
            this.lbWeekday.AutoSize = true;
            this.lbWeekday.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeekday.Location = new System.Drawing.Point(90, 300);
            this.lbWeekday.Name = "lbWeekday";
            this.lbWeekday.Size = new System.Drawing.Size(128, 40);
            this.lbWeekday.TabIndex = 24;
            this.lbWeekday.Text = "Lịch học";
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Location = new System.Drawing.Point(740, 72);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDay.TabIndex = 36;
            this.dtpStartDay.ValueChanged += new System.EventHandler(this.dtpStartDay_ValueChanged);
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Location = new System.Drawing.Point(740, 154);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDay.TabIndex = 37;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(236, 152);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(206, 24);
            this.cboCourse.TabIndex = 38;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(236, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 22);
            this.txtName.TabIndex = 39;
            // 
            // lbTeacher
            // 
            this.lbTeacher.AutoSize = true;
            this.lbTeacher.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeacher.Location = new System.Drawing.Point(538, 220);
            this.lbTeacher.Name = "lbTeacher";
            this.lbTeacher.Size = new System.Drawing.Size(280, 40);
            this.lbTeacher.TabIndex = 41;
            this.lbTeacher.Text = "Giáo viên phụ trách";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(90, 220);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(119, 40);
            this.lbPrice.TabIndex = 40;
            this.lbPrice.Text = "Học phí";
            // 
            // cboTeacher
            // 
            this.cboTeacher.FormattingEnabled = true;
            this.cboTeacher.Location = new System.Drawing.Point(819, 234);
            this.cboTeacher.Name = "cboTeacher";
            this.cboTeacher.Size = new System.Drawing.Size(121, 24);
            this.cboTeacher.TabIndex = 44;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonday.Location = new System.Drawing.Point(97, 367);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(121, 37);
            this.chkMonday.TabIndex = 45;
            this.chkMonday.Text = "Thứ hai";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTuesday.Location = new System.Drawing.Point(265, 367);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(114, 37);
            this.chkTuesday.TabIndex = 46;
            this.chkTuesday.Text = "Thứ ba";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWednesday.Location = new System.Drawing.Point(416, 367);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(112, 37);
            this.chkWednesday.TabIndex = 47;
            this.chkWednesday.Text = "Thứ tư";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkThursday.Location = new System.Drawing.Point(567, 367);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(137, 37);
            this.chkThursday.TabIndex = 48;
            this.chkThursday.Text = "Thứ năm";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFriday.Location = new System.Drawing.Point(740, 367);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(126, 37);
            this.chkFriday.TabIndex = 49;
            this.chkFriday.Text = "Thứ sáu";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(90, 483);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(119, 40);
            this.lbTime.TabIndex = 50;
            this.lbTime.Text = "Giờ học";
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaturday.Location = new System.Drawing.Point(321, 435);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(126, 37);
            this.chkSaturday.TabIndex = 51;
            this.chkSaturday.Text = "Thứ bảy";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSunday.Location = new System.Drawing.Point(527, 435);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(140, 37);
            this.chkSunday.TabIndex = 52;
            this.chkSunday.Text = "Chủ nhật";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 33);
            this.label2.TabIndex = 53;
            this.label2.Text = "h -";
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Location = new System.Drawing.Point(220, 497);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(28, 22);
            this.txtTimeStart.TabIndex = 54;
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Location = new System.Drawing.Point(286, 497);
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(28, 22);
            this.txtTimeEnd.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 33);
            this.label1.TabIndex = 56;
            this.label1.Text = "h";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(236, 234);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 57;
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Font = new System.Drawing.Font("Open Sans SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrency.Location = new System.Drawing.Point(363, 220);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(86, 40);
            this.lbCurrency.TabIndex = 58;
            this.lbCurrency.Text = "đồng";
            // 
            // ucInsertClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimeEnd);
            this.Controls.Add(this.txtTimeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkSunday);
            this.Controls.Add(this.chkSaturday);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.chkFriday);
            this.Controls.Add(this.chkThursday);
            this.Controls.Add(this.chkWednesday);
            this.Controls.Add(this.chkTuesday);
            this.Controls.Add(this.chkMonday);
            this.Controls.Add(this.cboTeacher);
            this.Controls.Add(this.lbTeacher);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.dtpEndDay);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbEnđay);
            this.Controls.Add(this.lbStartDay);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbWeekday);
            this.Name = "ucInsertClass";
            this.Size = new System.Drawing.Size(989, 754);
            this.Load += new System.EventHandler(this.ucInsertClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lbEnđay;
        private System.Windows.Forms.Label lbStartDay;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbWeekday;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbTeacher;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ComboBox cboTeacher;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbCurrency;
    }
}
