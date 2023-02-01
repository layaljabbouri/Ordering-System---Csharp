namespace OrderingSystem.Customer
{
    partial class TrackOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackOrder));
            this.topPanel = new System.Windows.Forms.Panel();
            this.close = new JImageButton.JImageButton();
            this.backBtn = new JImageButton.JImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ordernumberTxtBox = new JMaterialTextbox.JMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBtn = new JThinButton.JThinButton();
            this.statusTxtBox = new JMaterialTextbox.JMaterialTextbox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.topPanel.Controls.Add(this.close);
            this.topPanel.Controls.Add(this.backBtn);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(400, 109);
            this.topPanel.TabIndex = 2;
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
            this.close.Location = new System.Drawing.Point(356, 9);
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
            this.backBtn.Location = new System.Drawing.Point(7, 10);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(29, 25);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 72;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Track Order";
            // 
            // ordernumberTxtBox
            // 
            this.ordernumberTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.ordernumberTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ordernumberTxtBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernumberTxtBox.Font_Size = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernumberTxtBox.ForeColors = System.Drawing.Color.Black;
            this.ordernumberTxtBox.HintText = null;
            this.ordernumberTxtBox.IsPassword = false;
            this.ordernumberTxtBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.ordernumberTxtBox.LineThickness = 2;
            this.ordernumberTxtBox.Location = new System.Drawing.Point(40, 193);
            this.ordernumberTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ordernumberTxtBox.MaxLength = 32767;
            this.ordernumberTxtBox.Name = "ordernumberTxtBox";
            this.ordernumberTxtBox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.ordernumberTxtBox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.ordernumberTxtBox.ReadOnly = false;
            this.ordernumberTxtBox.Size = new System.Drawing.Size(309, 26);
            this.ordernumberTxtBox.TabIndex = 47;
            this.ordernumberTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ordernumberTxtBox.TextName = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(42, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Order Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(42, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Status";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.checkBtn.BorderColor = System.Drawing.Color.White;
            this.checkBtn.BorderRadius = 18;
            this.checkBtn.ButtonText = "Check";
            this.checkBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.ForeColors = System.Drawing.Color.White;
            this.checkBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.checkBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.checkBtn.HoverFontColor = System.Drawing.Color.White;
            this.checkBtn.LineThickness = 2;
            this.checkBtn.Location = new System.Drawing.Point(122, 377);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(4);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(135, 63);
            this.checkBtn.TabIndex = 50;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // statusTxtBox
            // 
            this.statusTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.statusTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.statusTxtBox.Enabled = false;
            this.statusTxtBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxtBox.Font_Size = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxtBox.ForeColors = System.Drawing.Color.Black;
            this.statusTxtBox.HintText = null;
            this.statusTxtBox.IsPassword = false;
            this.statusTxtBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.statusTxtBox.LineThickness = 3;
            this.statusTxtBox.Location = new System.Drawing.Point(40, 294);
            this.statusTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusTxtBox.MaxLength = 32767;
            this.statusTxtBox.Name = "statusTxtBox";
            this.statusTxtBox.OnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.statusTxtBox.OnFocusedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.statusTxtBox.ReadOnly = false;
            this.statusTxtBox.Size = new System.Drawing.Size(309, 26);
            this.statusTxtBox.TabIndex = 52;
            this.statusTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.statusTxtBox.TextName = "";
            // 
            // TrackOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.statusTxtBox);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordernumberTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrackOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackOrder";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private JImageButton.JImageButton close;
        private JImageButton.JImageButton backBtn;
        private JMaterialTextbox.JMaterialTextbox ordernumberTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private JThinButton.JThinButton checkBtn;
        private JMaterialTextbox.JMaterialTextbox statusTxtBox;
    }
}