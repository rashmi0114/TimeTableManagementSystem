namespace Time_Table_Management_System.LocationAllocation
{
    partial class ManageSessionRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSessionRoom));
            this.button2 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.comboBoxSessions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtSelectedSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(2, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 20);
            this.button2.TabIndex = 17;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(198, 29);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(270, 26);
            this.title.TabIndex = 43;
            this.title.Text = "Manage Session Rooms";
            // 
            // comboBoxSessions
            // 
            this.comboBoxSessions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSessions.FormattingEnabled = true;
            this.comboBoxSessions.Location = new System.Drawing.Point(22, 131);
            this.comboBoxSessions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSessions.Name = "comboBoxSessions";
            this.comboBoxSessions.Size = new System.Drawing.Size(137, 28);
            this.comboBoxSessions.TabIndex = 44;
            this.comboBoxSessions.SelectedIndexChanged += new System.EventHandler(this.comboBoxSessions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Select Session";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Select Room";
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(495, 132);
            this.comboBoxRooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(137, 28);
            this.comboBoxRooms.TabIndex = 47;
            this.comboBoxRooms.SelectedIndexChanged += new System.EventHandler(this.comboBoxRooms_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSubmit.Location = new System.Drawing.Point(273, 249);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 32);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear2.BackColor = System.Drawing.Color.Red;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear2.Location = new System.Drawing.Point(273, 301);
            this.btnClear2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(90, 32);
            this.btnClear2.TabIndex = 49;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtSelectedSession
            // 
            this.txtSelectedSession.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSelectedSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelectedSession.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedSession.Location = new System.Drawing.Point(202, 131);
            this.txtSelectedSession.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSelectedSession.Multiline = true;
            this.txtSelectedSession.Name = "txtSelectedSession";
            this.txtSelectedSession.ReadOnly = true;
            this.txtSelectedSession.Size = new System.Drawing.Size(257, 84);
            this.txtSelectedSession.TabIndex = 50;
            this.txtSelectedSession.TextChanged += new System.EventHandler(this.txtSelectedSession_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(262, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Selected Session";
            // 
            // ManageSessionRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(661, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSelectedSession);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBoxRooms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSessions);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button2);
            this.Name = "ManageSessionRoom";
            this.Text = "ManageSessionRoom";
            this.Load += new System.EventHandler(this.ManageSessionRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox comboBoxSessions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRooms;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtSelectedSession;
        private System.Windows.Forms.Label label3;
    }
}