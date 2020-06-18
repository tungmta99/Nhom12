namespace QLHS_GV_THPT
{
    partial class frmGiaoVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tkMa = new System.Windows.Forms.ToolStripMenuItem();
            this.tkTen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxTD = new System.Windows.Forms.TextBox();
            this.textBoxQQ = new System.Windows.Forms.TextBox();
            this.dateTimePickerNS = new System.Windows.Forms.DateTimePicker();
            this.textBoxTGV = new System.Windows.Forms.TextBox();
            this.textBoxMGV = new System.Windows.Forms.TextBox();
            this.comboBoxGT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnTimKiem,
            this.btnLamMoi,
            this.btnThoat});
            this.menuStrip1.Location = new System.Drawing.Point(67, 259);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(762, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 27);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 27);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 27);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 27);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tkMa,
            this.tkTen});
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimKiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 27);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tkMa
            // 
            this.tkMa.Name = "tkMa";
            this.tkMa.Size = new System.Drawing.Size(293, 28);
            this.tkMa.Text = "Tìm kiếm theo mã";
            this.tkMa.Click += new System.EventHandler(this.tkMa_Click);
            // 
            // tkTen
            // 
            this.tkTen.Name = "tkTen";
            this.tkTen.Size = new System.Drawing.Size(293, 28);
            this.tkTen.Text = "Tìm kiếm theo tên";
            this.tkTen.Click += new System.EventHandler(this.tkTen_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(116, 27);
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 27);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSDT);
            this.groupBox1.Controls.Add(this.textBoxTD);
            this.groupBox1.Controls.Add(this.textBoxQQ);
            this.groupBox1.Controls.Add(this.dateTimePickerNS);
            this.groupBox1.Controls.Add(this.textBoxTGV);
            this.groupBox1.Controls.Add(this.textBoxMGV);
            this.groupBox1.Controls.Add(this.comboBoxGT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(562, 156);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(169, 28);
            this.textBoxSDT.TabIndex = 15;
            // 
            // textBoxTD
            // 
            this.textBoxTD.Location = new System.Drawing.Point(562, 110);
            this.textBoxTD.Name = "textBoxTD";
            this.textBoxTD.Size = new System.Drawing.Size(169, 28);
            this.textBoxTD.TabIndex = 14;
            // 
            // textBoxQQ
            // 
            this.textBoxQQ.Location = new System.Drawing.Point(562, 53);
            this.textBoxQQ.Name = "textBoxQQ";
            this.textBoxQQ.Size = new System.Drawing.Size(169, 28);
            this.textBoxQQ.TabIndex = 13;
            // 
            // dateTimePickerNS
            // 
            this.dateTimePickerNS.Location = new System.Drawing.Point(220, 216);
            this.dateTimePickerNS.Name = "dateTimePickerNS";
            this.dateTimePickerNS.Size = new System.Drawing.Size(169, 28);
            this.dateTimePickerNS.TabIndex = 12;
            // 
            // textBoxTGV
            // 
            this.textBoxTGV.Location = new System.Drawing.Point(221, 105);
            this.textBoxTGV.Name = "textBoxTGV";
            this.textBoxTGV.Size = new System.Drawing.Size(169, 28);
            this.textBoxTGV.TabIndex = 10;
            // 
            // textBoxMGV
            // 
            this.textBoxMGV.Location = new System.Drawing.Point(221, 53);
            this.textBoxMGV.Name = "textBoxMGV";
            this.textBoxMGV.Size = new System.Drawing.Size(169, 28);
            this.textBoxMGV.TabIndex = 9;
            // 
            // comboBoxGT
            // 
            this.comboBoxGT.FormattingEnabled = true;
            this.comboBoxGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGT.Location = new System.Drawing.Point(220, 161);
            this.comboBoxGT.Name = "comboBoxGT";
            this.comboBoxGT.Size = new System.Drawing.Size(169, 28);
            this.comboBoxGT.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trình độ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(428, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giáo viên";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-5, 325);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(808, 159);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoVien";
            this.Text = "Giáo viên";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnLuu;
        private System.Windows.Forms.ToolStripMenuItem btnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem tkMa;
        private System.Windows.Forms.ToolStripMenuItem tkTen;
        private System.Windows.Forms.ToolStripMenuItem btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGT;
        private System.Windows.Forms.TextBox textBoxMGV;
        private System.Windows.Forms.TextBox textBoxTGV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNS;
        private System.Windows.Forms.TextBox textBoxQQ;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxTD;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem btnLamMoi;
    }
}