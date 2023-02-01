namespace OrderingSystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnTrackOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new JImageButton.JImageButton();
            this.backBtn = new JImageButton.JImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.newOrderBtn = new JImageButton.JImageButton();
            this.trackOrderBtn = new JImageButton.JImageButton();
            this.newCustomerRadioBtn = new System.Windows.Forms.RadioButton();
            this.specialCustomerRadioBtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnNewOrder.Location = new System.Drawing.Point(35, 373);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(138, 29);
            this.btnNewOrder.TabIndex = 59;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnTrackOrder
            // 
            this.btnTrackOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnTrackOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackOrder.FlatAppearance.BorderSize = 0;
            this.btnTrackOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnTrackOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnTrackOrder.Location = new System.Drawing.Point(221, 373);
            this.btnTrackOrder.Name = "btnTrackOrder";
            this.btnTrackOrder.Size = new System.Drawing.Size(138, 29);
            this.btnTrackOrder.TabIndex = 58;
            this.btnTrackOrder.Text = "Track Order";
            this.btnTrackOrder.UseVisualStyleBackColor = false;
            this.btnTrackOrder.Click += new System.EventHandler(this.btnTrackOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 94);
            this.panel1.TabIndex = 68;
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
            this.closeBtn.Location = new System.Drawing.Point(368, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 25);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 74;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
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
            this.backBtn.Location = new System.Drawing.Point(7, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(29, 25);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 70;
            this.backBtn.Zoom = 4;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.newOrderBtn.CausesValidation = false;
            this.newOrderBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.newOrderBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("newOrderBtn.ErrorImage")));
            this.newOrderBtn.Image = global::OrderingSystem.Properties.Resources.restaurant_100px;
            this.newOrderBtn.ImageHover = null;
            this.newOrderBtn.InitialImage = null;
            this.newOrderBtn.Location = new System.Drawing.Point(35, 245);
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(138, 122);
            this.newOrderBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.newOrderBtn.TabIndex = 67;
            this.newOrderBtn.Zoom = 4;
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // trackOrderBtn
            // 
            this.trackOrderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.trackOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.trackOrderBtn.CausesValidation = false;
            this.trackOrderBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackOrderBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("trackOrderBtn.ErrorImage")));
            this.trackOrderBtn.Image = global::OrderingSystem.Properties.Resources.where_to_quest_100px;
            this.trackOrderBtn.ImageHover = null;
            this.trackOrderBtn.InitialImage = null;
            this.trackOrderBtn.Location = new System.Drawing.Point(221, 245);
            this.trackOrderBtn.Name = "trackOrderBtn";
            this.trackOrderBtn.Size = new System.Drawing.Size(138, 122);
            this.trackOrderBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.trackOrderBtn.TabIndex = 64;
            this.trackOrderBtn.Zoom = 4;
            this.trackOrderBtn.Click += new System.EventHandler(this.trackOrderBtn_Click);
            // 
            // newCustomerRadioBtn
            // 
            this.newCustomerRadioBtn.AutoSize = true;
            this.newCustomerRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.newCustomerRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.newCustomerRadioBtn.Location = new System.Drawing.Point(36, 154);
            this.newCustomerRadioBtn.Name = "newCustomerRadioBtn";
            this.newCustomerRadioBtn.Size = new System.Drawing.Size(129, 21);
            this.newCustomerRadioBtn.TabIndex = 69;
            this.newCustomerRadioBtn.TabStop = true;
            this.newCustomerRadioBtn.Text = "New Customer";
            this.newCustomerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // specialCustomerRadioBtn
            // 
            this.specialCustomerRadioBtn.AutoSize = true;
            this.specialCustomerRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.specialCustomerRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.specialCustomerRadioBtn.Location = new System.Drawing.Point(222, 154);
            this.specialCustomerRadioBtn.Name = "specialCustomerRadioBtn";
            this.specialCustomerRadioBtn.Size = new System.Drawing.Size(152, 21);
            this.specialCustomerRadioBtn.TabIndex = 70;
            this.specialCustomerRadioBtn.TabStop = true;
            this.specialCustomerRadioBtn.Text = "Special Customer";
            this.specialCustomerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.specialCustomerRadioBtn);
            this.Controls.Add(this.newCustomerRadioBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newOrderBtn);
            this.Controls.Add(this.trackOrderBtn);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnTrackOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnTrackOrder;
        private JImageButton.JImageButton trackOrderBtn;
        private JImageButton.JImageButton newOrderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private JImageButton.JImageButton backBtn;
        private System.Windows.Forms.RadioButton newCustomerRadioBtn;
        private System.Windows.Forms.RadioButton specialCustomerRadioBtn;
        private JImageButton.JImageButton closeBtn;
    }
}