using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_GV_THPT
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        Database con = new Database();
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text.TrimEnd();
            string password = txtMK.Text.TrimEnd();
            bool check = con.Check(password, "SELECT MatKhau FROM dbo.TaiKhoan WHERE TenTaiKhoan ='" + username + "'");

            if (txtTK.Text != "" && txtMK.Text != "" && check == true)
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thong tin không chính xác !!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTK.Clear();
                txtMK.Clear();
            }
        }
    }
}
