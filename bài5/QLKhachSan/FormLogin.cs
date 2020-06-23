using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhachSanVui
{
    public partial class FormLogin : Form
    {
        public FormMain frmMain;
        String fullname="";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private bool passw()
        {
            if (txtmatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool tendn()
        {
            if (txttenDangnhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (tendn() && passw())
            {
                return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (kiemtra())
            {
                SqlConnection con = DataBase.GetConnection();
                SqlCommand cmd = new SqlCommand("CheckLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", txttenDangnhap.Text));
                cmd.Parameters.Add(new SqlParameter("@password", txtmatKhau.Text));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    if (reader != null)
                    {
                        fullname = (String)reader["fullname"];
                        frmMain.mfullname = fullname;
                        frmMain.mchucvu = (String)reader["chucvu"];
                        frmMain.musername = (String)reader["username"];
                        MessageBox.Show("Đăng nhập thành công!\nXin chào " + fullname, "Đăng nhập thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                    }
                    else
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
