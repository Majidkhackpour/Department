namespace Department.Order
{
    partial class frmOrderMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderMain));
            this.fPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblConCode = new System.Windows.Forms.Label();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSearchCust = new DevComponents.DotNetBar.ButtonX();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpProduct = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnEnseraf = new DevComponents.DotNetBar.ButtonX();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnInsert = new DevComponents.DotNetBar.ButtonX();
            this.txtPrdName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnFinish = new DevComponents.DotNetBar.ButtonX();
            this.DGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgRadif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prdGuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.grpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fPanel
            // 
            this.fPanel.Location = new System.Drawing.Point(594, 32);
            this.fPanel.Name = "fPanel";
            this.fPanel.Size = new System.Drawing.Size(203, 519);
            this.fPanel.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblConCode);
            this.groupPanel1.Controls.Add(this.lblTimeNow);
            this.groupPanel1.Controls.Add(this.lblDateNow);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label15);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 32);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(585, 45);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 2;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.groupPanel1.Style.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 2;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 2;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 2;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 92;
            // 
            // lblConCode
            // 
            this.lblConCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConCode.BackColor = System.Drawing.Color.Transparent;
            this.lblConCode.Location = new System.Drawing.Point(357, 9);
            this.lblConCode.Name = "lblConCode";
            this.lblConCode.Size = new System.Drawing.Size(124, 20);
            this.lblConCode.TabIndex = 15;
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeNow.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeNow.Location = new System.Drawing.Point(3, 9);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(93, 20);
            this.lblTimeNow.TabIndex = 15;
            // 
            // lblDateNow
            // 
            this.lblDateNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateNow.BackColor = System.Drawing.Color.Transparent;
            this.lblDateNow.Location = new System.Drawing.Point(163, 9);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(121, 20);
            this.lblDateNow.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(493, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "شماره قرارداد";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(108, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "زمان";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(296, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "تاریخ ثبت";
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnSearchCust);
            this.groupPanel2.Controls.Add(this.txtCustName);
            this.groupPanel2.Controls.Add(this.lblCompanyName);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.label6);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(3, 83);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(585, 52);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 2;
            this.groupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.groupPanel2.Style.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 2;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 2;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 2;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 0;
            // 
            // btnSearchCust
            // 
            this.btnSearchCust.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchCust.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearchCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchCust.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnSearchCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCust.Location = new System.Drawing.Point(305, 9);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnSearchCust.Size = new System.Drawing.Size(30, 27);
            this.btnSearchCust.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnSearchCust.TabIndex = 0;
            this.btnSearchCust.Text = "...";
            this.btnSearchCust.TextColor = System.Drawing.Color.White;
            this.btnSearchCust.Click += new System.EventHandler(this.btnSearchCust_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustName.Enabled = false;
            this.txtCustName.Location = new System.Drawing.Point(341, 9);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(190, 27);
            this.txtCustName.TabIndex = 18;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 12);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(195, 20);
            this.lblCompanyName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(541, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "طرف";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(204, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "نام واحد اقتصادی";
            // 
            // grpProduct
            // 
            this.grpProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProduct.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpProduct.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpProduct.Controls.Add(this.btnEnseraf);
            this.grpProduct.Controls.Add(this.txtTotal);
            this.grpProduct.Controls.Add(this.txtDiscount);
            this.grpProduct.Controls.Add(this.txtSum);
            this.grpProduct.Controls.Add(this.btnInsert);
            this.grpProduct.Controls.Add(this.txtPrdName);
            this.grpProduct.Controls.Add(this.label12);
            this.grpProduct.Controls.Add(this.label10);
            this.grpProduct.Controls.Add(this.label13);
            this.grpProduct.Controls.Add(this.label14);
            this.grpProduct.DisabledBackColor = System.Drawing.Color.Empty;
            this.grpProduct.Location = new System.Drawing.Point(3, 139);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(585, 145);
            // 
            // 
            // 
            this.grpProduct.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.grpProduct.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.grpProduct.Style.BackColorGradientAngle = 90;
            this.grpProduct.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpProduct.Style.BorderBottomWidth = 2;
            this.grpProduct.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.grpProduct.Style.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(195)))), ((int)(((byte)(198)))));
            this.grpProduct.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpProduct.Style.BorderLeftWidth = 2;
            this.grpProduct.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpProduct.Style.BorderRightWidth = 2;
            this.grpProduct.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpProduct.Style.BorderTopWidth = 2;
            this.grpProduct.Style.CornerDiameter = 4;
            this.grpProduct.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpProduct.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpProduct.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpProduct.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpProduct.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpProduct.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpProduct.TabIndex = 1;
            // 
            // btnEnseraf
            // 
            this.btnEnseraf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnseraf.BackColor = System.Drawing.Color.Silver;
            this.btnEnseraf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnseraf.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnEnseraf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnseraf.Location = new System.Drawing.Point(16, 93);
            this.btnEnseraf.Name = "btnEnseraf";
            this.btnEnseraf.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnEnseraf.Size = new System.Drawing.Size(190, 31);
            this.btnEnseraf.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnEnseraf.TabIndex = 4;
            this.btnEnseraf.Text = "انصراف";
            this.btnEnseraf.TextColor = System.Drawing.Color.Black;
            this.btnEnseraf.Click += new System.EventHandler(this.btnEnseraf_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(16, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(190, 27);
            this.txtTotal.TabIndex = 2;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(341, 51);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(184, 27);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(16, 9);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(190, 27);
            this.txtSum.TabIndex = 0;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsert.BackColor = System.Drawing.Color.Silver;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInsert.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Location = new System.Drawing.Point(341, 93);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnInsert.Size = new System.Drawing.Size(184, 31);
            this.btnInsert.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "ثبت در قراداد";
            this.btnInsert.TextColor = System.Drawing.Color.Black;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtPrdName
            // 
            this.txtPrdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrdName.Enabled = false;
            this.txtPrdName.Location = new System.Drawing.Point(341, 9);
            this.txtPrdName.Name = "txtPrdName";
            this.txtPrdName.ReadOnly = true;
            this.txtPrdName.Size = new System.Drawing.Size(184, 27);
            this.txtPrdName.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(548, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "کالا";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(230, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "قیمت کل";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(532, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "تخفیف";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(212, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "قیمت فروش";
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
            this.btnCancel.Location = new System.Drawing.Point(20, 561);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnCancel.Size = new System.Drawing.Size(190, 31);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "انصراف (Esc)";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinish.BackColor = System.Drawing.Color.Silver;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinish.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Image = global::Department.Properties.Resources.tab_checkbox__;
            this.btnFinish.Location = new System.Drawing.Point(345, 561);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnFinish.Size = new System.Drawing.Size(184, 31);
            this.btnFinish.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013;
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "تایید (F5)";
            this.btnFinish.TextColor = System.Drawing.Color.Black;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // DGrid
            // 
            this.DGrid.AllowUserToAddRows = false;
            this.DGrid.AllowUserToDeleteRows = false;
            this.DGrid.AllowUserToResizeColumns = false;
            this.DGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGrid.AutoGenerateColumns = false;
            this.DGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgRadif,
            this.productNameDataGridViewTextBoxColumn,
            this.Count,
            this.totalDataGridViewTextBoxColumn,
            this.orderGuidDataGridViewTextBoxColumn,
            this.prdGuidDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.dgGuid,
            this.modifiedDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.DGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.DGrid.DataSource = this.orderBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGrid.Location = new System.Drawing.Point(3, 291);
            this.DGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGrid.Name = "DGrid";
            this.DGrid.ReadOnly = true;
            this.DGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGrid.Size = new System.Drawing.Size(585, 207);
            this.DGrid.TabIndex = 55764;
            this.DGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGrid_CellFormatting);
            // 
            // dgRadif
            // 
            this.dgRadif.HeaderText = "ردیف";
            this.dgRadif.Name = "dgRadif";
            this.dgRadif.ReadOnly = true;
            this.dgRadif.Width = 50;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "عنوان کالا";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 60;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalDataGridViewTextBoxColumn.HeaderText = "جمع کل";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderGuidDataGridViewTextBoxColumn
            // 
            this.orderGuidDataGridViewTextBoxColumn.DataPropertyName = "OrderGuid";
            this.orderGuidDataGridViewTextBoxColumn.HeaderText = "OrderGuid";
            this.orderGuidDataGridViewTextBoxColumn.Name = "orderGuidDataGridViewTextBoxColumn";
            this.orderGuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderGuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // prdGuidDataGridViewTextBoxColumn
            // 
            this.prdGuidDataGridViewTextBoxColumn.DataPropertyName = "PrdGuid";
            this.prdGuidDataGridViewTextBoxColumn.HeaderText = "PrdGuid";
            this.prdGuidDataGridViewTextBoxColumn.Name = "prdGuidDataGridViewTextBoxColumn";
            this.prdGuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.prdGuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Visible = false;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgGuid
            // 
            this.dgGuid.DataPropertyName = "Guid";
            this.dgGuid.HeaderText = "Guid";
            this.dgGuid.Name = "dgGuid";
            this.dgGuid.ReadOnly = true;
            this.dgGuid.Visible = false;
            // 
            // modifiedDataGridViewTextBoxColumn
            // 
            this.modifiedDataGridViewTextBoxColumn.DataPropertyName = "Modified";
            this.modifiedDataGridViewTextBoxColumn.HeaderText = "Modified";
            this.modifiedDataGridViewTextBoxColumn.Name = "modifiedDataGridViewTextBoxColumn";
            this.modifiedDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifiedDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 74);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(180, 24);
            this.mnuEdit.Text = "ویرایش کالای جاری";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(180, 24);
            this.mnuDelete.Text = "حذف کالای جاری";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(DepartmentDal.Classes.OrderDetailBussines);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("B Yekan", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalPrice.Location = new System.Drawing.Point(124, 502);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(300, 40);
            this.lblTotalPrice.TabIndex = 55766;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(66, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 55767;
            this.label9.Text = "ریال";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(430, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 55768;
            this.label8.Text = "جمع کل قرارداد";
            // 
            // frmOrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGrid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.fPanel);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmOrderMain";
            this.Padding = new System.Windows.Forms.Padding(27, 92, 27, 31);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.frmOrderMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOrderMain_KeyDown);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fPanel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label lblConCode;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnSearchCust;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.GroupPanel grpProduct;
        private System.Windows.Forms.TextBox txtPrdName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSum;
        private DevComponents.DotNetBar.ButtonX btnEnseraf;
        private DevComponents.DotNetBar.ButtonX btnInsert;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnFinish;
        private DevComponents.DotNetBar.Controls.DataGridViewX DGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRadif;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prdGuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}