namespace Time_Table_Management_System.Messages
{
    partial class SuccessMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSuccessMessage = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Successfully!";
            // 
            // labelSuccessMessage
            // 
            this.labelSuccessMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuccessMessage.AutoSize = true;
            this.labelSuccessMessage.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccessMessage.ForeColor = System.Drawing.Color.Black;
            this.labelSuccessMessage.Location = new System.Drawing.Point(77, 103);
            this.labelSuccessMessage.Name = "labelSuccessMessage";
            this.labelSuccessMessage.Size = new System.Drawing.Size(252, 34);
            this.labelSuccessMessage.TabIndex = 2;
            this.labelSuccessMessage.Text = "success message";
            this.labelSuccessMessage.Click += new System.EventHandler(this.labelSuccessMessage_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkay.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Location = new System.Drawing.Point(441, 198);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(125, 48);
            this.btnOkay.TabIndex = 3;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelSuccessMessage);
            this.panel1.Controls.Add(this.btnOkay);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 260);
            this.panel1.TabIndex = 4;
            // 
            // SuccessMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(580, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuccessMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessMessage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSuccessMessage;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Panel panel1;
    }
}