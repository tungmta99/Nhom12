namespace QLThuVien
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInforUser = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonBAGB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Quản Lý Thư Viện";
            // 
            // buttonInforUser
            // 
            this.buttonInforUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonInforUser.Image")));
            this.buttonInforUser.Location = new System.Drawing.Point(191, 182);
            this.buttonInforUser.Name = "buttonInforUser";
            this.buttonInforUser.Size = new System.Drawing.Size(92, 96);
            this.buttonInforUser.TabIndex = 1;
            this.buttonInforUser.UseVisualStyleBackColor = true;
            this.buttonInforUser.Click += new System.EventHandler(this.buttonInforUser_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Image = ((System.Drawing.Image)(resources.GetObject("buttonBook.Image")));
            this.buttonBook.Location = new System.Drawing.Point(498, 182);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(96, 96);
            this.buttonBook.TabIndex = 2;
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonBAGB
            // 
            this.buttonBAGB.Image = ((System.Drawing.Image)(resources.GetObject("buttonBAGB.Image")));
            this.buttonBAGB.Location = new System.Drawing.Point(340, 182);
            this.buttonBAGB.Name = "buttonBAGB";
            this.buttonBAGB.Size = new System.Drawing.Size(96, 96);
            this.buttonBAGB.TabIndex = 4;
            this.buttonBAGB.UseVisualStyleBackColor = true;
            this.buttonBAGB.Click += new System.EventHandler(this.buttonBAGB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 458);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(631, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 458);
            this.panel2.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBAGB);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInforUser);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInforUser;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonBAGB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}