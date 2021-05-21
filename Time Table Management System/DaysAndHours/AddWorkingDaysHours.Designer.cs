﻿namespace Time_Table_Management_System.DaysAndHours
{
    partial class AddWorkingDaysHours
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkingDaysHours));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericNoOfDays = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericTPerDayHours = new System.Windows.Forms.NumericUpDown();
            this.numericTPerDayMinutes = new System.Windows.Forms.NumericUpDown();
            this.errorAddWorkingDays = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoOfDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddWorkingDays)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(547, 288);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 32);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(442, 288);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numericNoOfDays
            // 
            this.numericNoOfDays.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.numericNoOfDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericNoOfDays.Enabled = false;
            this.numericNoOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericNoOfDays.Location = new System.Drawing.Point(232, 94);
            this.numericNoOfDays.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericNoOfDays.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericNoOfDays.Name = "numericNoOfDays";
            this.numericNoOfDays.ReadOnly = true;
            this.numericNoOfDays.Size = new System.Drawing.Size(83, 24);
            this.numericNoOfDays.TabIndex = 30;
            this.numericNoOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClose.Location = new System.Drawing.Point(2, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 20);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(77, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "No of Working Days";
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(87, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(275, 26);
            this.title.TabIndex = 26;
            this.title.Text = "Add Working Days Hours";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(77, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Working Days";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(77, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Working Time Per Day";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(328, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(490, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Minutes";
            // 
            // numericTPerDayHours
            // 
            this.numericTPerDayHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericTPerDayHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericTPerDayHours.Location = new System.Drawing.Point(232, 213);
            this.numericTPerDayHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericTPerDayHours.Name = "numericTPerDayHours";
            this.numericTPerDayHours.Size = new System.Drawing.Size(83, 24);
            this.numericTPerDayHours.TabIndex = 39;
            this.numericTPerDayHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericTPerDayMinutes
            // 
            this.numericTPerDayMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericTPerDayMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numericTPerDayMinutes.Location = new System.Drawing.Point(394, 213);
            this.numericTPerDayMinutes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericTPerDayMinutes.Name = "numericTPerDayMinutes";
            this.numericTPerDayMinutes.Size = new System.Drawing.Size(83, 24);
            this.numericTPerDayMinutes.TabIndex = 40;
            this.numericTPerDayMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorAddWorkingDays
            // 
            this.errorAddWorkingDays.ContainerControl = this;
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxMonday.Location = new System.Drawing.Point(11, 9);
            this.checkBoxMonday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMonday.TabIndex = 41;
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            this.checkBoxMonday.CheckedChanged += new System.EventHandler(this.checkBoxMonday_CheckedChanged);
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxTuesday.Location = new System.Drawing.Point(82, 11);
            this.checkBoxTuesday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(67, 17);
            this.checkBoxTuesday.TabIndex = 42;
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            this.checkBoxTuesday.CheckedChanged += new System.EventHandler(this.checkBoxTuesday_CheckedChanged);
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxSunday.Location = new System.Drawing.Point(89, 41);
            this.checkBoxSunday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(62, 17);
            this.checkBoxSunday.TabIndex = 43;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            this.checkBoxSunday.CheckedChanged += new System.EventHandler(this.checkBoxSunday_CheckedChanged);
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxFriday.Location = new System.Drawing.Point(326, 11);
            this.checkBoxFriday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(54, 17);
            this.checkBoxFriday.TabIndex = 44;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            this.checkBoxFriday.CheckedChanged += new System.EventHandler(this.checkBoxFriday_CheckedChanged);
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxThursday.Location = new System.Drawing.Point(248, 11);
            this.checkBoxThursday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(70, 17);
            this.checkBoxThursday.TabIndex = 45;
            this.checkBoxThursday.Text = "Thursday";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            this.checkBoxThursday.CheckedChanged += new System.EventHandler(this.checkBoxThursday_CheckedChanged);
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxWednesday.Location = new System.Drawing.Point(158, 11);
            this.checkBoxWednesday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(83, 17);
            this.checkBoxWednesday.TabIndex = 46;
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            this.checkBoxWednesday.CheckedChanged += new System.EventHandler(this.checkBoxWednesday_CheckedChanged);
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxSaturday.Location = new System.Drawing.Point(10, 41);
            this.checkBoxSaturday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(68, 17);
            this.checkBoxSaturday.TabIndex = 47;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            this.checkBoxSaturday.CheckedChanged += new System.EventHandler(this.checkBoxSaturday_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Location = new System.Drawing.Point(434, 288);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 38);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(547, 288);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 38);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBoxMonday);
            this.panel1.Controls.Add(this.checkBoxTuesday);
            this.panel1.Controls.Add(this.checkBoxSunday);
            this.panel1.Controls.Add(this.checkBoxSaturday);
            this.panel1.Controls.Add(this.checkBoxFriday);
            this.panel1.Controls.Add(this.checkBoxWednesday);
            this.panel1.Controls.Add(this.checkBoxThursday);
            this.panel1.Location = new System.Drawing.Point(232, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 66);
            this.panel1.TabIndex = 50;
            // 
            // AddWorkingDaysHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numericTPerDayMinutes);
            this.Controls.Add(this.numericTPerDayHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericNoOfDays);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddWorkingDaysHours";
            this.Text = "AddWorkingDaysHours";
            this.Load += new System.EventHandler(this.AddWorkingDaysHours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNoOfDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTPerDayMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddWorkingDays)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericNoOfDays;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericTPerDayHours;
        private System.Windows.Forms.NumericUpDown numericTPerDayMinutes;
        private System.Windows.Forms.ErrorProvider errorAddWorkingDays;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}