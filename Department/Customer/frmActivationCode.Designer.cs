namespace Department.Customer
{
    partial class frmActivationCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivationCode));
            this.grp = new DevComponents.DotNetBar.PanelEx();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picSms = new System.Windows.Forms.PictureBox();
            this.txtFanni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateCode = new DevComponents.DotNetBar.ButtonX();
            this.lblActivationCode = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.NumericUpDown();
            this.label79 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppSerial = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.btnFinish = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnLog = new DevComponents.DotNetBar.ButtonX();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.CanvasColor = System.Drawing.SystemColors.Control;
            this.grp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.grp.Controls.Add(this.txtDesc);
            this.grp.Controls.Add(this.picEmail);
            this.grp.Controls.Add(this.picSms);
            this.grp.Controls.Add(this.txtFanni);
            this.grp.Controls.Add(this.label5);
            this.grp.Controls.Add(this.btnLog);
            this.grp.Controls.Add(this.btnGenerateCode);
            this.grp.Controls.Add(this.lblActivationCode);
            this.grp.Controls.Add(this.txtTerm);
            this.grp.Controls.Add(this.label79);
            this.grp.Controls.Add(this.label4);
            this.grp.Controls.Add(this.label2);
            this.grp.Controls.Add(this.lblAppSerial);
            this.grp.Controls.Add(this.lblExpDate);
            this.grp.Controls.Add(this.lblName);
            this.grp.Controls.Add(this.label1);
            this.grp.Controls.Add(this.label6);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label78);
            this.grp.DisabledBackColor = System.Drawing.Color.Empty;
            this.grp.Location = new System.Drawing.Point(3, 8);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(516, 479);
            this.grp.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.grp.Style.BackColor1.Color = System.Drawing.Color.White;
            this.grp.Style.BackColor2.Color = System.Drawing.Color.White;
            this.grp.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.grp.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.grp.Style.BorderWidth = 2;
            this.grp.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grp.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grp.Style.GradientAngle = 90;
            this.grp.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(100, 344);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(308, 119);
            this.txtDesc.TabIndex = 3;
            // 
            // picEmail
            // 
            this.picEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmail.Image = global::Department.Properties.Resources.Mail3;
            this.picEmail.Location = new System.Drawing.Point(8, 289);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(40, 31);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmail.TabIndex = 20;
            this.picEmail.TabStop = false;
            this.picEmail.Click += new System.EventHandler(this.picEmail_Click);
            // 
            // picSms
            // 
            this.picSms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSms.Image = global::Department.Properties.Resources.sms_6_icon;
            this.picSms.Location = new System.Drawing.Point(54, 289);
            this.picSms.Name = "picSms";
            this.picSms.Size = new System.Drawing.Size(40, 31);
            this.picSms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSms.TabIndex = 20;
            this.picSms.TabStop = false;
            this.picSms.Click += new System.EventHandler(this.picSms_Click);
            // 
            // txtFanni
            // 
            this.txtFanni.Location = new System.Drawing.Point(100, 191);
            this.txtFanni.Name = "txtFanni";
            this.txtFanni.Size = new System.Drawing.Size(308, 27);
            this.txtFanni.TabIndex = 1;
            this.txtFanni.Enter += new System.EventHandler(this.txtFanni_Enter);
            this.txtFanni.Leave += new System.EventHandler(this.txtFanni_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(414, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "مشخصه مشتری";
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerateCode.BackColor = System.Drawing.Color.Silver;
            this.btnGenerateCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateCode.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnGenerateCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCode.Location = new System.Drawing.Point(100, 289);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnGenerateCode.Size = new System.Drawing.Size(308, 31);
            this.btnGenerateCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnGenerateCode.TabIndex = 2;
            this.btnGenerateCode.Text = "تولید کد فعالسازی";
            this.btnGenerateCode.TextColor = System.Drawing.Color.Black;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // lblActivationCode
            // 
            this.lblActivationCode.BackColor = System.Drawing.Color.Transparent;
            this.lblActivationCode.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblActivationCode.ForeColor = System.Drawing.Color.Red;
            this.lblActivationCode.Location = new System.Drawing.Point(100, 241);
            this.lblActivationCode.Name = "lblActivationCode";
            this.lblActivationCode.Size = new System.Drawing.Size(308, 30);
            this.lblActivationCode.TabIndex = 17;
            this.lblActivationCode.Text = "00";
            this.lblActivationCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTerm
            // 
            this.txtTerm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTerm.Location = new System.Drawing.Point(100, 145);
            this.txtTerm.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(308, 27);
            this.txtTerm.TabIndex = 0;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.Location = new System.Drawing.Point(63, 147);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(22, 20);
            this.label79.TabIndex = 15;
            this.label79.Text = "ماه";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(410, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "سریال نرم افزار";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(410, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "تاریخ پایان اعتبار";
            // 
            // lblAppSerial
            // 
            this.lblAppSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppSerial.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSerial.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAppSerial.Location = new System.Drawing.Point(18, 101);
            this.lblAppSerial.Name = "lblAppSerial";
            this.lblAppSerial.Size = new System.Drawing.Size(386, 27);
            this.lblAppSerial.TabIndex = 16;
            this.lblAppSerial.Text = "0000";
            this.lblAppSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExpDate
            // 
            this.lblExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpDate.Location = new System.Drawing.Point(162, 59);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(227, 20);
            this.lblExpDate.TabIndex = 16;
            this.lblExpDate.Text = "0000";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(162, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(227, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "0000";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(425, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "عنوان مشتری";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(445, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "توضیحات";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(431, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "کد فعالسازی";
            // 
            // label78
            // 
            this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Location = new System.Drawing.Point(437, 147);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(62, 20);
            this.label78.TabIndex = 16;
            this.label78.Text = "مدت اعتبار";
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinish.BackColor = System.Drawing.Color.Silver;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinish.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Image = global::Department.Properties.Resources.tab_checkbox__;
            this.btnFinish.Location = new System.Drawing.Point(373, 506);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnFinish.Size = new System.Drawing.Size(125, 31);
            this.btnFinish.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "تایید (F5)";
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
            this.btnCancel.Image = global::Department.Properties.Resources.tab_close_;
            this.btnCancel.Location = new System.Drawing.Point(21, 506);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCancel.Size = new System.Drawing.Size(125, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف (Esc)";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLog
            // 
            this.btnLog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLog.BackColor = System.Drawing.Color.Silver;
            this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLog.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLog.Location = new System.Drawing.Point(8, 347);
            this.btnLog.Name = "btnLog";
            this.btnLog.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnLog.Size = new System.Drawing.Size(86, 31);
            this.btnLog.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "لاگ مشتری";
            this.btnLog.TextColor = System.Drawing.Color.Black;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmActivationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 549);
            this.ControlBox = false;
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grp);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivationCode";
            this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmActivationCode_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmActivationCode_KeyDown);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx grp;
        private DevComponents.DotNetBar.ButtonX btnFinish;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.NumericUpDown txtTerm;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label78;
        private DevComponents.DotNetBar.ButtonX btnGenerateCode;
        private System.Windows.Forms.Label lblActivationCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAppSerial;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFanni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picSms;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDesc;
        private DevComponents.DotNetBar.ButtonX btnLog;
    }
}