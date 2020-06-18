namespace QLHS_GV_THPT
{
    partial class frmGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDien));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDN = new System.Windows.Forms.Button();
            this.buttonDK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "        HỆ THỐNG QUẢN LÝ\r\nHỌC SINH VÀ GIÁO VIÊN THPT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDN
            // 
            this.buttonDN.BackColor = System.Drawing.Color.Aqua;
            this.buttonDN.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDN.Location = new System.Drawing.Point(297, 298);
            this.buttonDN.Name = "buttonDN";
            this.buttonDN.Size = new System.Drawing.Size(198, 52);
            this.buttonDN.TabIndex = 2;
            this.buttonDN.Text = "Đăng nhập";
            this.buttonDN.UseVisualStyleBackColor = false;
            this.buttonDN.Click += new System.EventHandler(this.buttonDN_Click);
            // 
            // buttonDK
            // 
            this.buttonDK.BackColor = System.Drawing.Color.Blue;
            this.buttonDK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDK.Location = new System.Drawing.Point(326, 356);
            this.buttonDK.Name = "buttonDK";
            this.buttonDK.Size = new System.Drawing.Size(146, 36);
            this.buttonDK.TabIndex = 3;
            this.buttonDK.Text = "Đăng ký";
            this.buttonDK.UseVisualStyleBackColor = false;
            this.buttonDK.Click += new System.EventHandler(this.buttonDK_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 200);
            this.panel1.TabIndex = 4;
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDK);
            this.Controls.Add(this.buttonDN);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoDien";
            this.Text = "Giao diện";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDN;
        private System.Windows.Forms.Button buttonDK;
        private System.Windows.Forms.Panel panel1;
    }
}