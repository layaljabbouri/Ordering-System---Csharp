namespace OrderingSystem
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.staffBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.btnStaff = new JImageButton.JImageButton();
            this.btnCustomer = new JImageButton.JImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new JImageButton.JImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.Transparent;
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.FlatAppearance.BorderSize = 0;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.staffBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.staffBtn.Location = new System.Drawing.Point(235, 315);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(124, 29);
            this.staffBtn.TabIndex = 69;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.Transparent;
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.FlatAppearance.BorderSize = 0;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.customerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.customerBtn.Location = new System.Drawing.Point(29, 315);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(124, 29);
            this.customerBtn.TabIndex = 68;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click_1);
            // 
            // btnStaff
            // 
            this.btnStaff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnStaff.CausesValidation = false;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStaff.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnStaff.ErrorImage")));
            this.btnStaff.Image = global::OrderingSystem.Properties.Resources.chef_hat_100px;
            this.btnStaff.ImageHover = null;
            this.btnStaff.InitialImage = null;
            this.btnStaff.Location = new System.Drawing.Point(235, 192);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(124, 112);
            this.btnStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStaff.TabIndex = 71;
            this.btnStaff.Zoom = 4;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnCustomer.CausesValidation = false;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCustomer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ErrorImage")));
            this.btnCustomer.Image = global::OrderingSystem.Properties.Resources.account_70px;
            this.btnCustomer.ImageHover = null;
            this.btnCustomer.InitialImage = null;
            this.btnCustomer.Location = new System.Drawing.Point(29, 192);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(124, 112);
            this.btnCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCustomer.TabIndex = 70;
            this.btnCustomer.Zoom = 4;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 101);
            this.panel1.TabIndex = 72;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.closeBtn.CausesValidation = false;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.ErrorImage")));
            this.closeBtn.Image = global::OrderingSystem.Properties.Resources.Close_26px;
            this.closeBtn.ImageHover = null;
            this.closeBtn.InitialImage = null;
            this.closeBtn.Location = new System.Drawing.Point(359, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 73;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Continue As";
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.customerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private JImageButton.JImageButton btnStaff;
        private JImageButton.JImageButton btnCustomer;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JImageButton.JImageButton closeBtn;
    }
}