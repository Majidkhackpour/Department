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
            this.btnFinish = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.txtTerm = new System.Windows.Forms.NumericUpDown();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActivationCode = new System.Windows.Forms.Label();
            this.btnGenerateCode = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblAppSerial = new System.Windows.Forms.Label();
            this.txtFanni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.CanvasColor = System.Drawing.SystemColors.Control;
            this.grp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.grp.Controls.Add(this.txtFanni);
            this.grp.Controls.Add(this.label5);
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
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label78);
            this.grp.DisabledBackColor = System.Drawing.Color.Empty;
            this.grp.Location = new System.Drawing.Point(3, 44);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(391, 334);
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
            // btnFinish
            // 
            this.btnFinish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinish.BackColor = System.Drawing.Color.Silver;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinish.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Image = global::Department.Properties.Resources.tab_checkbox__;
            this.btnFinish.Location = new System.Drawing.Point(248, 401);
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
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::Department.Properties.Resources.tab_close_;
            this.btnCancel.Location = new System.Drawing.Point(21, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCancel.Size = new System.Drawing.Size(125, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف (Esc)";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.txtTerm.Size = new System.Drawing.Size(196, 27);
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
            // label78
            // 
            this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Location = new System.Drawing.Point(312, 147);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(62, 20);
            this.label78.TabIndex = 16;
            this.label78.Text = "مدت اعتبار";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(300, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "عنوان مشتری";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(285, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "تاریخ پایان اعتبار";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(306, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "کد فعالسازی";
            // 
            // lblActivationCode
            // 
            this.lblActivationCode.BackColor = System.Drawing.Color.Transparent;
            this.lblActivationCode.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblActivationCode.ForeColor = System.Drawing.Color.Red;
            this.lblActivationCode.Location = new System.Drawing.Point(12, 241);
            this.lblActivationCode.Name = "lblActivationCode";
            this.lblActivationCode.Size = new System.Drawing.Size(278, 30);
            this.lblActivationCode.TabIndex = 17;
            this.lblActivationCode.Text = "00";
            this.lblActivationCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGenerateCode.BackColor = System.Drawing.Color.Silver;
            this.btnGenerateCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateCode.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnGenerateCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateCode.Location = new System.Drawing.Point(94, 293);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnGenerateCode.Size = new System.Drawing.Size(196, 31);
            this.btnGenerateCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnGenerateCode.TabIndex = 2;
            this.btnGenerateCode.Text = "تولید کد فعالسازی";
            this.btnGenerateCode.TextColor = System.Drawing.Color.Black;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(285, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "سریال نرم افزار";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(37, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(227, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "0000";
            // 
            // lblExpDate
            // 
            this.lblExpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpDate.Location = new System.Drawing.Point(37, 59);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(227, 20);
            this.lblExpDate.TabIndex = 16;
            this.lblExpDate.Text = "0000";
            // 
            // lblAppSerial
            // 
            this.lblAppSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppSerial.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSerial.Location = new System.Drawing.Point(37, 101);
            this.lblAppSerial.Name = "lblAppSerial";
            this.lblAppSerial.Size = new System.Drawing.Size(227, 20);
            this.lblAppSerial.TabIndex = 16;
            this.lblAppSerial.Text = "0000";
            // 
            // txtFanni
            // 
            this.txtFanni.Location = new System.Drawing.Point(100, 191);
            this.txtFanni.Name = "txtFanni";
            this.txtFanni.Size = new System.Drawing.Size(196, 27);
            this.txtFanni.TabIndex = 1;
            this.txtFanni.Enter += new System.EventHandler(this.txtFanni_Enter);
            this.txtFanni.Leave += new System.EventHandler(this.txtFanni_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(297, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "مشخصه مشتری";
            // 
            // frmActivationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 447);
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
    }
}