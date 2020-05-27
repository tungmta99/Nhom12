namespace AppQuanlyKho_PM1
{
    partial class Form1
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
            this.nhâpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuâtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vâtTưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnViToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCâpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngươiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvStorage = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSumInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSumStock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSumOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStorage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhâpKhoToolStripMenuItem,
            this.xuâtKhoToolStripMenuItem,
            this.vâtTưToolStripMenuItem,
            this.đơnViToolStripMenuItem,
            this.nhaCungCâpToolStripMenuItem,
            this.khachHangToolStripMenuItem,
            this.ngươiDungToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(837, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhâpKhoToolStripMenuItem
            // 
            this.nhâpKhoToolStripMenuItem.Name = "nhâpKhoToolStripMenuItem";
            this.nhâpKhoToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.nhâpKhoToolStripMenuItem.Text = "Nhập kho";
            // 
            // xuâtKhoToolStripMenuItem
            // 
            this.xuâtKhoToolStripMenuItem.Name = "xuâtKhoToolStripMenuItem";
            this.xuâtKhoToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.xuâtKhoToolStripMenuItem.Text = "Xuất kho";
            // 
            // vâtTưToolStripMenuItem
            // 
            this.vâtTưToolStripMenuItem.Name = "vâtTưToolStripMenuItem";
            this.vâtTưToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.vâtTưToolStripMenuItem.Text = "Vật tư ";
            // 
            // đơnViToolStripMenuItem
            // 
            this.đơnViToolStripMenuItem.Name = "đơnViToolStripMenuItem";
            this.đơnViToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.đơnViToolStripMenuItem.Text = "Đơn vị ";
            // 
            // nhaCungCâpToolStripMenuItem
            // 
            this.nhaCungCâpToolStripMenuItem.Name = "nhaCungCâpToolStripMenuItem";
            this.nhaCungCâpToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
            this.nhaCungCâpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // khachHangToolStripMenuItem
            // 
            this.khachHangToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.khachHangToolStripMenuItem.Name = "khachHangToolStripMenuItem";
            this.khachHangToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.khachHangToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.khachHangToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.khachHangToolStripMenuItem.Text = "Khách hàng ";
            // 
            // ngươiDungToolStripMenuItem
            // 
            this.ngươiDungToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ngươiDungToolStripMenuItem.Name = "ngươiDungToolStripMenuItem";
            this.ngươiDungToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.ngươiDungToolStripMenuItem.Text = "Người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(250, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ KHO ABC";
            // 
            // dtgvStorage
            // 
            this.dtgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStorage.Location = new System.Drawing.Point(13, 230);
            this.dtgvStorage.Name = "dtgvStorage";
            this.dtgvStorage.RowHeadersWidth = 51;
            this.dtgvStorage.RowTemplate.Height = 24;
            this.dtgvStorage.Size = new System.Drawing.Size(811, 371);
            this.dtgvStorage.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(371, 197);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(340, 24);
            this.textBoxSearch.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(717, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRefresh.Location = new System.Drawing.Point(12, 195);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(106, 29);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelSumInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 84);
            this.panel1.TabIndex = 6;
            // 
            // labelSumInput
            // 
            this.labelSumInput.AutoSize = true;
            this.labelSumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSumInput.Location = new System.Drawing.Point(56, 50);
            this.labelSumInput.Name = "labelSumInput";
            this.labelSumInput.Size = new System.Drawing.Size(72, 20);
            this.labelSumInput.TabIndex = 1;
            this.labelSumInput.Text = "loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(55, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lượng nhập:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.labelSumStock);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(288, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 84);
            this.panel2.TabIndex = 7;
            // 
            // labelSumStock
            // 
            this.labelSumStock.AutoSize = true;
            this.labelSumStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSumStock.Location = new System.Drawing.Point(56, 50);
            this.labelSumStock.Name = "labelSumStock";
            this.labelSumStock.Size = new System.Drawing.Size(72, 20);
            this.labelSumStock.TabIndex = 1;
            this.labelSumStock.Text = "loading...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(55, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tồn kho:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.labelSumOutput);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(562, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 84);
            this.panel3.TabIndex = 7;
            // 
            // labelSumOutput
            // 
            this.labelSumOutput.AutoSize = true;
            this.labelSumOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelSumOutput.Location = new System.Drawing.Point(56, 50);
            this.labelSumOutput.Name = "labelSumOutput";
            this.labelSumOutput.Size = new System.Drawing.Size(72, 20);
            this.labelSumOutput.TabIndex = 1;
            this.labelSumOutput.Text = "loading...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(55, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lượng xuất:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dtgvStorage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStorage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhâpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuâtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vâtTưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnViToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCâpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngươiDungToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvStorage;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSumInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSumStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSumOutput;
        private System.Windows.Forms.Label label7;
    }
}

