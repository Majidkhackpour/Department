namespace Department.Users
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grp = new DevComponents.DotNetBar.PanelEx();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinish = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.lblRecoveryPassword = new System.Windows.Forms.Label();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.CanvasColor = System.Drawing.SystemColors.Control;
            this.grp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.txtPassword);
            this.grp.Controls.Add(this.txtUserName);
            this.grp.DisabledBackColor = System.Drawing.Color.Empty;
            this.grp.Location = new System.Drawing.Point(8, 181);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(463, 129);
            this.grp.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.grp.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.grp.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.grp.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.grp.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.grp.Style.BorderWidth = 2;
            this.grp.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grp.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grp.Style.GradientAngle = 90;
            this.grp.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(382, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "رمز عبور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(377, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "نام کاربری";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(22, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(330, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUserName.Location = new System.Drawing.Point(22, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(330, 27);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Yekan", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "نرم افزار جامع مدیریت مشتریان آراد";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Department.Properties.Resources.Arad_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(176, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinish.BackColor = System.Drawing.Color.Silver;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinish.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Image = global::Department.Properties.Resources.tab_checkbox__;
            this.btnFinish.Location = new System.Drawing.Point(330, 357);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnFinish.Size = new System.Drawing.Size(125, 31);
            this.btnFinish.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "ورود به سیستم";
            this.btnFinish.TextColor = System.Drawing.Color.Black;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Department.Properties.Resources.tab_close_;
            this.btnCancel.Location = new System.Drawing.Point(30, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCancel.Size = new System.Drawing.Size(125, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "خروج";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRecoveryPassword
            // 
            this.lblRecoveryPassword.AutoSize = true;
            this.lblRecoveryPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRecoveryPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRecoveryPassword.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecoveryPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblRecoveryPassword.Location = new System.Drawing.Point(140, 319);
            this.lblRecoveryPassword.Name = "lblRecoveryPassword";
            this.lblRecoveryPassword.Size = new System.Drawing.Size(184, 20);
            this.lblRecoveryPassword.TabIndex = 12;
            this.lblRecoveryPassword.Text = "رمز عبور خود را فراموش کرده ام...!";
            this.lblRecoveryPassword.MouseEnter += new System.EventHandler(this.lblRecoveryPassword_MouseEnter);
            this.lblRecoveryPassword.MouseLeave += new System.EventHandler(this.lblRecoveryPassword_MouseLeave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(481, 412);
            this.Controls.Add(this.lblRecoveryPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx grp;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnFinish;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRecoveryPassword;
    }
}