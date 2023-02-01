namespace OrderingSystem.Staff
{
    partial class CheckOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOrders));
            this.topPanel = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.close = new JImageButton.JImageButton();
            this.backBtn = new JImageButton.JImageButton();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.topPanel.Controls.Add(this.headerLbl);
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Controls.Add(this.backBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(500, 62);
            this.topPanel.TabIndex = 52;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Verdana", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(141, 15);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(201, 32);
            this.headerLbl.TabIndex = 73;
            this.headerLbl.Text = "Check Order";
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.centerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.centerPanel.Location = new System.Drawing.Point(12, 103);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(477, 381);
            this.centerPanel.TabIndex = 53;
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.Enabled = false;
            this.totalTxtBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.totalTxtBox.Location = new System.Drawing.Point(193, 513);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.Size = new System.Drawing.Size(197, 27);
            this.totalTxtBox.TabIndex = 3;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.totalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.totalLbl.Location = new System.Drawing.Point(114, 513);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(64, 26);
            this.totalLbl.TabIndex = 2;
            this.totalLbl.Text = "Total";
            // 
            // close
            // 
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.CausesValidation = false;
            this.close.Cursor = System.Windows.Forms.Cursors.Default;
            this.close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("close.ErrorImage")));
            this.close.Image = global::OrderingSystem.Properties.Resources.Close_26px;
            this.close.ImageHover = null;
            this.close.InitialImage = null;
            this.close.Location = new System.Drawing.Point(449, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.close.TabIndex = 71;
            this.close.Zoom = 4;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.backBtn.CausesValidation = false;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.backBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backBtn.ErrorImage")));
            this.backBtn.Image = global::OrderingSystem.Properties.Resources.backwhite_26px;
            this.backBtn.ImageHover = null;
            this.backBtn.InitialImage = null;
            this.backBtn.Location = new System.Drawing.Point(11, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(29, 25);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 72;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CheckOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 567);
            this.Controls.Add(this.totalTxtBox);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOrders";
            this.Load += new System.EventHandler(this.CheckOrders_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private JImageButton.JImageButton close;
        private JImageButton.JImageButton backBtn;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.TextBox totalTxtBox;
        private System.Windows.Forms.Label totalLbl;
    }
}