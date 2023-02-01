namespace OrderingSystem
{
    partial class OrderConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderConfirmation));
            this.btmPanel = new System.Windows.Forms.Panel();
            this.orderNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.DataGridView();
            this.billPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBtn = new JThinButton.JThinButton();
            this.modifyBtn = new JThinButton.JThinButton();
            this.cancelBtn = new JThinButton.JThinButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.backBtn = new JImageButton.JImageButton();
            this.btmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // btmPanel
            // 
            this.btmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btmPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btmPanel.Controls.Add(this.orderNumberTxtBox);
            this.btmPanel.Controls.Add(this.label3);
            this.btmPanel.Controls.Add(this.totalTxtBox);
            this.btmPanel.Controls.Add(this.label1);
            this.btmPanel.Location = new System.Drawing.Point(0, 402);
            this.btmPanel.Name = "btmPanel";
            this.btmPanel.Size = new System.Drawing.Size(448, 56);
            this.btmPanel.TabIndex = 2;
            // 
            // orderNumberTxtBox
            // 
            this.orderNumberTxtBox.Enabled = false;
            this.orderNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.orderNumberTxtBox.Location = new System.Drawing.Point(85, 16);
            this.orderNumberTxtBox.Name = "orderNumberTxtBox";
            this.orderNumberTxtBox.Size = new System.Drawing.Size(129, 24);
            this.orderNumberTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = " Order \r\nNumber";
            // 
            // totalTxtBox
            // 
            this.totalTxtBox.Enabled = false;
            this.totalTxtBox.Font = new System.Drawing.Font("Tahoma", 10F);
            this.totalTxtBox.Location = new System.Drawing.Point(304, 16);
            this.totalTxtBox.Name = "totalTxtBox";
            this.totalTxtBox.Size = new System.Drawing.Size(129, 24);
            this.totalTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // topPanel
            // 
            this.topPanel.AllowUserToOrderColumns = true;
            this.topPanel.BackgroundColor = System.Drawing.Color.White;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topPanel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(448, 56);
            this.topPanel.TabIndex = 0;
            // 
            // billPanel
            // 
            this.billPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.billPanel.Location = new System.Drawing.Point(1, 62);
            this.billPanel.Name = "billPanel";
            this.billPanel.Size = new System.Drawing.Size(442, 340);
            this.billPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Preview";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BackgroundColor = System.Drawing.Color.White;
            this.confirmBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.confirmBtn.BorderRadius = 15;
            this.confirmBtn.ButtonText = "Confirm";
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.confirmBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.confirmBtn.HoverBackground = System.Drawing.Color.White;
            this.confirmBtn.HoverBorder = System.Drawing.Color.White;
            this.confirmBtn.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.confirmBtn.LineThickness = 2;
            this.confirmBtn.Location = new System.Drawing.Point(333, 478);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(91, 43);
            this.confirmBtn.TabIndex = 0;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.BackColor = System.Drawing.Color.Transparent;
            this.modifyBtn.BackgroundColor = System.Drawing.Color.White;
            this.modifyBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.modifyBtn.BorderRadius = 15;
            this.modifyBtn.ButtonText = "Modify";
            this.modifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modifyBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.modifyBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.modifyBtn.HoverBackground = System.Drawing.Color.White;
            this.modifyBtn.HoverBorder = System.Drawing.Color.White;
            this.modifyBtn.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.modifyBtn.LineThickness = 2;
            this.modifyBtn.Location = new System.Drawing.Point(181, 478);
            this.modifyBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(91, 43);
            this.modifyBtn.TabIndex = 1;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BackgroundColor = System.Drawing.Color.White;
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.cancelBtn.BorderRadius = 15;
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cancelBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.cancelBtn.HoverBackground = System.Drawing.Color.White;
            this.cancelBtn.HoverBorder = System.Drawing.Color.White;
            this.cancelBtn.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.cancelBtn.LineThickness = 2;
            this.cancelBtn.Location = new System.Drawing.Point(25, 478);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(91, 43);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.CausesValidation = false;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.ErrorImage")));
            this.closeBtn.Image = global::OrderingSystem.Properties.Resources.Closeblue_26px;
            this.closeBtn.ImageHover = null;
            this.closeBtn.InitialImage = null;
            this.closeBtn.Location = new System.Drawing.Point(406, 16);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.CausesValidation = false;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.backBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("backBtn.ErrorImage")));
            this.backBtn.Image = global::OrderingSystem.Properties.Resources.back_26px;
            this.backBtn.ImageHover = null;
            this.backBtn.InitialImage = null;
            this.backBtn.Location = new System.Drawing.Point(13, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(29, 25);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 7;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // OrderConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(448, 535);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifyBtn);
            this.Controls.Add(this.billPanel);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btmPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderConfirmation";
            this.Load += new System.EventHandler(this.OrderConfirmation_Load);
            this.btmPanel.ResumeLayout(false);
            this.btmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel btmPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView topPanel;
        private System.Windows.Forms.Panel billPanel;
        private System.Windows.Forms.Label label2;
        private JThinButton.JThinButton confirmBtn;
        private JThinButton.JThinButton cancelBtn;
        private JThinButton.JThinButton modifyBtn;
        private System.Windows.Forms.TextBox totalTxtBox;
        private JImageButton.JImageButton closeBtn;
        private JImageButton.JImageButton backBtn;
        private System.Windows.Forms.TextBox orderNumberTxtBox;
        private System.Windows.Forms.Label label3;
    }
}