using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            if ((textBoxID.Text == "admin") && (textBoxPass.Text == "123456"))
            {
                this.Hide();
                Home hm = new Home();
                hm.ShowDialog();
               // this.Close();
            }
            else
            {
                MessageBox.Show("Sai Mật Khẩu");
            }
        }
    }
}
