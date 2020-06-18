namespace QLHS_GV_THPT
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnTKB = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnHuongDan);
            this.panel1.Controls.Add(this.btnTKB);
            this.panel1.Controls.Add(this.btnGiaoVien);
            this.panel1.Controls.Add(this.btnHocSinh);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 494);
            this.panel1.TabIndex = 0;
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.Image")));
            this.btnHuongDan.Location = new System.Drawing.Point(461, 263);
            this.btnHuongDan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(145, 111);
            this.btnHuongDan.TabIndex = 7;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongDan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnTKB
            // 
            this.btnTKB.Image = ((System.Drawing.Image)(resources.GetObject("btnTKB.Image")));
            this.btnTKB.Location = new System.Drawing.Point(461, 126);
            this.btnTKB.Margin = new System.Windows.Forms.Padding(4);
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.Size = new System.Drawing.Size(145, 107);
            this.btnTKB.TabIndex = 6;
            this.btnTKB.Text = "Thời khóa biểu";
            this.btnTKB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTKB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTKB.UseVisualStyleBackColor = true;
            this.btnTKB.Click += new System.EventHandler(this.btnTKB_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Image")));
            this.btnGiaoVien.Location = new System.Drawing.Point(174, 263);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(145, 111);
            this.btnGiaoVien.TabIndex = 5;
            this.btnGiaoVien.Text = "Quản lý giáo viên";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaoVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.BackColor = System.Drawing.SystemColors.Control;
            this.btnHocSinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocSinh.Image")));
            this.btnHocSinh.Location = new System.Drawing.Point(174, 126);
            this.btnHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(145, 107);
            this.btnHocSinh.TabIndex = 4;
            this.btnHocSinh.Text = "Quản lý học sinh";
            this.btnHocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnTKB;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnHocSinh;
    }
}