namespace QLKhachSanVui
{
    partial class FormDoiMK
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
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtMkc = new System.Windows.Forms.TextBox();
            this.txtMkm = new System.Windows.Forms.TextBox();
            this.txtMkm2 = new System.Windows.Forms.TextBox();
            this.batloi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.batloi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(275, 240);
            this.btnXacnhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(100, 35);
            this.btnXacnhan.TabIndex = 0;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(84, 240);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(137, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(219, 78);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(48, 20);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "label6";
            // 
            // txtMkc
            // 
            this.txtMkc.Location = new System.Drawing.Point(223, 111);
            this.txtMkc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMkc.Name = "txtMkc";
            this.txtMkc.Size = new System.Drawing.Size(180, 27);
            this.txtMkc.TabIndex = 8;
            this.txtMkc.UseSystemPasswordChar = true;
            // 
            // txtMkm
            // 
            this.txtMkm.Location = new System.Drawing.Point(223, 151);
            this.txtMkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMkm.Name = "txtMkm";
            this.txtMkm.Size = new System.Drawing.Size(180, 27);
            this.txtMkm.TabIndex = 9;
            this.txtMkm.UseSystemPasswordChar = true;
            this.txtMkm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMkm_KeyUp);
            // 
            // txtMkm2
            // 
            this.txtMkm2.Location = new System.Drawing.Point(223, 190);
            this.txtMkm2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMkm2.Name = "txtMkm2";
            this.txtMkm2.Size = new System.Drawing.Size(180, 27);
            this.txtMkm2.TabIndex = 10;
            this.txtMkm2.UseSystemPasswordChar = true;
            this.txtMkm2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMkm2_KeyUp);
            // 
            // batloi
            // 
            this.batloi.ContainerControl = this;
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 302);
            this.Controls.Add(this.txtMkm2);
            this.Controls.Add(this.txtMkm);
            this.Controls.Add(this.txtMkc);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacnhan);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.Load += new System.EventHandler(this.FormDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batloi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtMkc;
        private System.Windows.Forms.TextBox txtMkm;
        private System.Windows.Forms.TextBox txtMkm2;
        private System.Windows.Forms.ErrorProvider batloi;
    }
}