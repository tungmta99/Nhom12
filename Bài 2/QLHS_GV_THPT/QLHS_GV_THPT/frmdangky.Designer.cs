namespace QLHS_GV_THPT
{
    partial class frmDangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtRMK = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(355, 145);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(263, 28);
            this.txtMK.TabIndex = 3;
            // 
            // txtRMK
            // 
            this.txtRMK.Location = new System.Drawing.Point(355, 190);
            this.txtRMK.Name = "txtRMK";
            this.txtRMK.PasswordChar = '*';
            this.txtRMK.Size = new System.Drawing.Size(263, 28);
            this.txtRMK.TabIndex = 4;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(355, 235);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(263, 28);
            this.txtsdt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đăng ký";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(355, 100);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(263, 28);
            this.txtTK.TabIndex = 10;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(355, 280);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(263, 28);
            this.txtemail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "email";
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.Color.Aqua;
            this.btndangky.Location = new System.Drawing.Point(302, 325);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(199, 59);
            this.btndangky.TabIndex = 13;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = false;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 482);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtRMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKy";
            this.Text = "Đăng Ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtRMK;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndangky;
    }
}