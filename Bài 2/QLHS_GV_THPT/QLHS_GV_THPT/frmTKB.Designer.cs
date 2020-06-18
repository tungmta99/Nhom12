namespace QLHS_GV_THPT
{
    partial class frmTKB
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
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.comboBoxGV = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTKB = new System.Windows.Forms.DataGridView();
            this.textBoxThu = new System.Windows.Forms.TextBox();
            this.textBoxMonHoc = new System.Windows.Forms.TextBox();
            this.textBoxTiet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(181, 70);
            this.comboBoxLop.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(165, 28);
            this.comboBoxLop.TabIndex = 0;
            this.comboBoxLop.SelectedIndexChanged += new System.EventHandler(this.comboBoxLop_SelectedIndexChanged);
            // 
            // comboBoxGV
            // 
            this.comboBoxGV.FormattingEnabled = true;
            this.comboBoxGV.Location = new System.Drawing.Point(369, 182);
            this.comboBoxGV.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGV.Name = "comboBoxGV";
            this.comboBoxGV.Size = new System.Drawing.Size(165, 28);
            this.comboBoxGV.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Aqua;
            this.btnThem.Location = new System.Drawing.Point(150, 238);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 38);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Aqua;
            this.btnSua.Location = new System.Drawing.Point(355, 238);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 38);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Aqua;
            this.btnXoa.Location = new System.Drawing.Point(553, 238);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thứ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giáo viên";
            // 
            // dataGridViewTKB
            // 
            this.dataGridViewTKB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTKB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTKB.Location = new System.Drawing.Point(-3, 297);
            this.dataGridViewTKB.Name = "dataGridViewTKB";
            this.dataGridViewTKB.RowHeadersWidth = 51;
            this.dataGridViewTKB.RowTemplate.Height = 24;
            this.dataGridViewTKB.Size = new System.Drawing.Size(808, 189);
            this.dataGridViewTKB.TabIndex = 13;
            this.dataGridViewTKB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTKB_CellContentClick);
            // 
            // textBoxThu
            // 
            this.textBoxThu.Location = new System.Drawing.Point(527, 70);
            this.textBoxThu.Name = "textBoxThu";
            this.textBoxThu.Size = new System.Drawing.Size(165, 28);
            this.textBoxThu.TabIndex = 15;
            // 
            // textBoxMonHoc
            // 
            this.textBoxMonHoc.Location = new System.Drawing.Point(181, 126);
            this.textBoxMonHoc.Name = "textBoxMonHoc";
            this.textBoxMonHoc.Size = new System.Drawing.Size(165, 28);
            this.textBoxMonHoc.TabIndex = 16;
            // 
            // textBoxTiet
            // 
            this.textBoxTiet.Location = new System.Drawing.Point(527, 126);
            this.textBoxTiet.Name = "textBoxTiet";
            this.textBoxTiet.Size = new System.Drawing.Size(165, 28);
            this.textBoxTiet.TabIndex = 17;
            // 
            // frmTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.textBoxTiet);
            this.Controls.Add(this.textBoxMonHoc);
            this.Controls.Add(this.textBoxThu);
            this.Controls.Add(this.dataGridViewTKB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.comboBoxGV);
            this.Controls.Add(this.comboBoxLop);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTKB";
            this.Text = "Thời Khóa Biểu ";
            this.Load += new System.EventHandler(this.frmTKB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTKB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.ComboBox comboBoxGV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewTKB;
        private System.Windows.Forms.TextBox textBoxThu;
        private System.Windows.Forms.TextBox textBoxMonHoc;
        private System.Windows.Forms.TextBox textBoxTiet;
    }
}

