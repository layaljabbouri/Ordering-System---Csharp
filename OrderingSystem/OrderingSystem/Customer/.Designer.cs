namespace OrderingSystem
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.resetBtn = new JThinButton.JThinButton();
            this.proceedBtn = new JThinButton.JThinButton();
            this.backBtn = new JImageButton.JImageButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(448, 62);
            this.topPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // centerPanel
            // 
            this.centerPanel.Location = new System.Drawing.Point(0, 62);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(448, 421);
            this.centerPanel.TabIndex = 7;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.BackgroundColor = System.Drawing.Color.White;
            this.resetBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.resetBtn.BorderRadius = 17;
            this.resetBtn.ButtonText = "Reset";
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.resetBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.resetBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.resetBtn.HoverBackground = System.Drawing.Color.White;
            this.resetBtn.HoverBorder = System.Drawing.Color.White;
            this.resetBtn.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.resetBtn.LineThickness = 2;
            this.resetBtn.Location = new System.Drawing.Point(57, 489);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(97, 43);
            this.resetBtn.TabIndex = 0;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.Transparent;
            this.proceedBtn.BackgroundColor = System.Drawing.Color.White;
            this.proceedBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.proceedBtn.BorderRadius = 17;
            this.proceedBtn.ButtonText = "Proceed";
            this.proceedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.proceedBtn.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.proceedBtn.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.proceedBtn.HoverBackground = System.Drawing.Color.White;
            this.proceedBtn.HoverBorder = System.Drawing.Color.White;
            this.proceedBtn.HoverFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.proceedBtn.LineThickness = 2;
            this.proceedBtn.Location = new System.Drawing.Point(297, 489);
            this.proceedBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(97, 43);
            this.proceedBtn.TabIndex = 8;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
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
            this.backBtn.Location = new System.Drawing.Point(13, 14);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(29, 25);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 10;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(406, 17);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(448, 544);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel centerPanel;
        private JThinButton.JThinButton resetBtn;
        private JThinButton.JThinButton proceedBtn;
        private JImageButton.JImageButton backBtn;
        private JImageButton.JImageButton closeBtn;
    }
}

