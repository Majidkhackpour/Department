namespace Department
{
    partial class frmDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastVorrod = new System.Windows.Forms.Label();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Department.Properties.Resources.Arad_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(21, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(702, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "کاربر جاری:";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.ForeColor = System.Drawing.Color.Silver;
            this.lblUserName.Location = new System.Drawing.Point(177, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(524, 24);
            this.lblUserName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(734, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "سِمت:";
            // 
            // lblTypeName
            // 
            this.lblTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeName.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeName.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTypeName.ForeColor = System.Drawing.Color.Silver;
            this.lblTypeName.Location = new System.Drawing.Point(476, 74);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(214, 24);
            this.lblTypeName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(387, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "آخرین ورود:";
            // 
            // lblLastVorrod
            // 
            this.lblLastVorrod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastVorrod.BackColor = System.Drawing.Color.Transparent;
            this.lblLastVorrod.Font = new System.Drawing.Font("B Yekan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLastVorrod.ForeColor = System.Drawing.Color.Silver;
            this.lblLastVorrod.Location = new System.Drawing.Point(150, 74);
            this.lblLastVorrod.Name = "lblLastVorrod";
            this.lblLastVorrod.Size = new System.Drawing.Size(231, 24);
            this.lblLastVorrod.TabIndex = 10;
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.ForeColor = System.Drawing.Color.Silver;
            this.line1.Location = new System.Drawing.Point(143, 132);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(631, 23);
            this.line1.TabIndex = 12;
            this.line1.Text = "line1";
            this.line1.Thickness = 2;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLastVorrod);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmDashBoard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastVorrod;
        private DevComponents.DotNetBar.Controls.Line line1;
    }
}