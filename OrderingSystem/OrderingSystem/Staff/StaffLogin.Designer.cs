namespace OrderingSystem
{
    partial class StaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogin));
            this.usernameTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.passwordTextBox = new JMaterialTextbox.JMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.proceedBtn = new JThinButton.JThinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new JImageButton.JImageButton();
            this.back = new JImageButton.JImageButton();
            this.jImageButton1 = new JImageButton.JImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Font_Size = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColors = System.Drawing.Color.Gray;
            this.usernameTextBox.HintText = null;
            this.usernameTextBox.IsPassword = false;
            this.usernameTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.usernameTextBox.LineThickness = 2;
            this.usernameTextBox.Location = new System.Drawing.Point(36, 217);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.usernameTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.Size = new System.Drawing.Size(309, 26);
            this.usernameTextBox.TabIndex = 43;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameTextBox.TextName = "someone.example";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextBox.ForeColors = System.Drawing.Color.Gray;
            this.passwordTextBox.HintText = null;
            this.passwordTextBox.IsPassword = true;
            this.passwordTextBox.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.passwordTextBox.LineThickness = 2;
            this.passwordTextBox.Location = new System.Drawing.Point(36, 292);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.OnFocusedColor = System.Drawing.Color.Black;
            this.passwordTextBox.OnFocusedTextColor = System.Drawing.Color.Black;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(309, 21);
            this.passwordTextBox.TabIndex = 44;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextBox.TextName = "PassWorD";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(38, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.label4.Location = new System.Drawing.Point(35, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Password";
            // 
            // proceedBtn
            // 
            this.proceedBtn.BackColor = System.Drawing.Color.Transparent;
            this.proceedBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.proceedBtn.BorderColor = System.Drawing.Color.White;
            this.proceedBtn.BorderRadius = 18;
            this.proceedBtn.ButtonText = "Proceed";
            this.proceedBtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedBtn.ForeColors = System.Drawing.Color.White;
            this.proceedBtn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.proceedBtn.HoverBorder = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.proceedBtn.HoverFontColor = System.Drawing.Color.White;
            this.proceedBtn.LineThickness = 2;
            this.proceedBtn.Location = new System.Drawing.Point(120, 352);
            this.proceedBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.proceedBtn.Name = "proceedBtn";
            this.proceedBtn.Size = new System.Drawing.Size(137, 59);
            this.proceedBtn.TabIndex = 45;
            this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.jImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 103);
            this.panel1.TabIndex = 46;
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
            this.close.Location = new System.Drawing.Point(347, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 39);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.close.TabIndex = 2;
            this.close.Zoom = 4;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.CausesValidation = false;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.ErrorImage = ((System.Drawing.Image)(resources.GetObject("back.ErrorImage")));
            this.back.Image = global::OrderingSystem.Properties.Resources.backwhite_26px;
            this.back.ImageHover = null;
            this.back.InitialImage = null;
            this.back.Location = new System.Drawing.Point(12, 15);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(25, 22);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back.TabIndex = 1;
            this.back.Zoom = 4;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // jImageButton1
            // 
            this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.jImageButton1.CausesValidation = false;
            this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
            this.jImageButton1.Image = global::OrderingSystem.Properties.Resources.account_70px;
            this.jImageButton1.ImageHover = null;
            this.jImageButton1.InitialImage = null;
            this.jImageButton1.Location = new System.Drawing.Point(120, 12);
            this.jImageButton1.Name = "jImageButton1";
            this.jImageButton1.Size = new System.Drawing.Size(137, 76);
            this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton1.TabIndex = 0;
            this.jImageButton1.Zoom = 4;
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.proceedBtn);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffLogin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JMaterialTextbox.JMaterialTextbox usernameTextBox;
        private JMaterialTextbox.JMaterialTextbox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private JThinButton.JThinButton proceedBtn;
        private System.Windows.Forms.Panel panel1;
        private JImageButton.JImageButton jImageButton1;
        private JImageButton.JImageButton close;
        private JImageButton.JImageButton back;
    }
}