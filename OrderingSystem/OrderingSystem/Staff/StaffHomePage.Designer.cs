namespace OrderingSystem.Staff
{
    partial class StaffHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffHomePage));
            this.btnInProgress = new System.Windows.Forms.Button();
            this.btnNowServing = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListOfOrders = new System.Windows.Forms.Button();
            this.listOfOrdersBtn = new JImageButton.JImageButton();
            this.logoutBtn = new JImageButton.JImageButton();
            this.closeBtn = new JImageButton.JImageButton();
            this.completedBtn = new JImageButton.JImageButton();
            this.inProgressBtn = new JImageButton.JImageButton();
            this.nowServingBtn = new JImageButton.JImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInProgress
            // 
            this.btnInProgress.BackColor = System.Drawing.Color.Transparent;
            this.btnInProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInProgress.FlatAppearance.BorderSize = 0;
            this.btnInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnInProgress.Location = new System.Drawing.Point(29, 241);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(138, 37);
            this.btnInProgress.TabIndex = 69;
            this.btnInProgress.Text = "In Progress";
            this.btnInProgress.UseVisualStyleBackColor = false;
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // btnNowServing
            // 
            this.btnNowServing.BackColor = System.Drawing.Color.Transparent;
            this.btnNowServing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNowServing.FlatAppearance.BorderSize = 0;
            this.btnNowServing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNowServing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnNowServing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnNowServing.Location = new System.Drawing.Point(215, 241);
            this.btnNowServing.Name = "btnNowServing";
            this.btnNowServing.Size = new System.Drawing.Size(138, 37);
            this.btnNowServing.TabIndex = 68;
            this.btnNowServing.Text = "Now Serving";
            this.btnNowServing.UseVisualStyleBackColor = false;
            this.btnNowServing.Click += new System.EventHandler(this.btnNowServing_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.Transparent;
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.FlatAppearance.BorderSize = 0;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnCompleted.Location = new System.Drawing.Point(29, 426);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(138, 37);
            this.btnCompleted.TabIndex = 72;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 58);
            this.panel1.TabIndex = 74;
            // 
            // btnListOfOrders
            // 
            this.btnListOfOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnListOfOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListOfOrders.FlatAppearance.BorderSize = 0;
            this.btnListOfOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnListOfOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.btnListOfOrders.Location = new System.Drawing.Point(215, 426);
            this.btnListOfOrders.Name = "btnListOfOrders";
            this.btnListOfOrders.Size = new System.Drawing.Size(138, 37);
            this.btnListOfOrders.TabIndex = 75;
            this.btnListOfOrders.Text = "All Orders";
            this.btnListOfOrders.UseVisualStyleBackColor = false;
            this.btnListOfOrders.Click += new System.EventHandler(this.btnListOfOrders_Click);
            // 
            // listOfOrdersBtn
            // 
            this.listOfOrdersBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listOfOrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.listOfOrdersBtn.CausesValidation = false;
            this.listOfOrdersBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.listOfOrdersBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("listOfOrdersBtn.ErrorImage")));
            this.listOfOrdersBtn.Image = global::OrderingSystem.Properties.Resources.list_100px;
            this.listOfOrdersBtn.ImageHover = null;
            this.listOfOrdersBtn.InitialImage = null;
            this.listOfOrdersBtn.Location = new System.Drawing.Point(215, 298);
            this.listOfOrdersBtn.Name = "listOfOrdersBtn";
            this.listOfOrdersBtn.Size = new System.Drawing.Size(138, 122);
            this.listOfOrdersBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.listOfOrdersBtn.TabIndex = 76;
            this.listOfOrdersBtn.Zoom = 4;
            this.listOfOrdersBtn.Click += new System.EventHandler(this.listOfOrdersBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.logoutBtn.CausesValidation = false;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoutBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logoutBtn.ErrorImage")));
            this.logoutBtn.Image = global::OrderingSystem.Properties.Resources.logout;
            this.logoutBtn.ImageHover = null;
            this.logoutBtn.InitialImage = null;
            this.logoutBtn.Location = new System.Drawing.Point(7, 9);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(37, 37);
            this.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoutBtn.TabIndex = 70;
            this.logoutBtn.Zoom = 4;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
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
            this.closeBtn.TabIndex = 69;
            this.closeBtn.Zoom = 4;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // completedBtn
            // 
            this.completedBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.completedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.completedBtn.CausesValidation = false;
            this.completedBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.completedBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("completedBtn.ErrorImage")));
            this.completedBtn.Image = global::OrderingSystem.Properties.Resources.Done_100px;
            this.completedBtn.ImageHover = null;
            this.completedBtn.InitialImage = null;
            this.completedBtn.Location = new System.Drawing.Point(29, 298);
            this.completedBtn.Name = "completedBtn";
            this.completedBtn.Size = new System.Drawing.Size(138, 122);
            this.completedBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.completedBtn.TabIndex = 73;
            this.completedBtn.Zoom = 4;
            this.completedBtn.Click += new System.EventHandler(this.completedBtn_Click);
            // 
            // inProgressBtn
            // 
            this.inProgressBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.inProgressBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.inProgressBtn.CausesValidation = false;
            this.inProgressBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.inProgressBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("inProgressBtn.ErrorImage")));
            this.inProgressBtn.Image = global::OrderingSystem.Properties.Resources.iphone_spinner_100px;
            this.inProgressBtn.ImageHover = null;
            this.inProgressBtn.InitialImage = null;
            this.inProgressBtn.Location = new System.Drawing.Point(29, 113);
            this.inProgressBtn.Name = "inProgressBtn";
            this.inProgressBtn.Size = new System.Drawing.Size(138, 122);
            this.inProgressBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.inProgressBtn.TabIndex = 71;
            this.inProgressBtn.Zoom = 4;
            this.inProgressBtn.Click += new System.EventHandler(this.inProgressBtn_Click);
            // 
            // nowServingBtn
            // 
            this.nowServingBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nowServingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.nowServingBtn.CausesValidation = false;
            this.nowServingBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.nowServingBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("nowServingBtn.ErrorImage")));
            this.nowServingBtn.Image = global::OrderingSystem.Properties.Resources.food_service_100px;
            this.nowServingBtn.ImageHover = null;
            this.nowServingBtn.InitialImage = null;
            this.nowServingBtn.Location = new System.Drawing.Point(215, 113);
            this.nowServingBtn.Name = "nowServingBtn";
            this.nowServingBtn.Size = new System.Drawing.Size(138, 122);
            this.nowServingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nowServingBtn.TabIndex = 70;
            this.nowServingBtn.Zoom = 4;
            this.nowServingBtn.Click += new System.EventHandler(this.nowServingBtn_Click);
            // 
            // StaffHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.listOfOrdersBtn);
            this.Controls.Add(this.btnListOfOrders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.completedBtn);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.inProgressBtn);
            this.Controls.Add(this.nowServingBtn);
            this.Controls.Add(this.btnInProgress);
            this.Controls.Add(this.btnNowServing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffHomePage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private JImageButton.JImageButton inProgressBtn;
        private JImageButton.JImageButton nowServingBtn;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.Button btnNowServing;
        private JImageButton.JImageButton completedBtn;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Panel panel1;
        private JImageButton.JImageButton logoutBtn;
        private JImageButton.JImageButton closeBtn;
        private JImageButton.JImageButton listOfOrdersBtn;
        private System.Windows.Forms.Button btnListOfOrders;
    }
}