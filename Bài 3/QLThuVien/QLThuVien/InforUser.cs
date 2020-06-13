using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QLThuVien
{
    public partial class InforUser : Form
    {
        public InforUser()
        {
            InitializeComponent();
        }

        SqlConnection con;

        private void InforUser_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        public void HienThi()
        {
            string sqlSelect = "Select * from DocGia";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewDG.DataSource = dt;
            dataGridViewDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InforUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void buttonAddDG_Click(object sender, EventArgs e)
        {
            string sqlInsert = "Insert into DocGia Values (@MaDocGia, @TenDocGia, @DiaChi, @CMND, @NgaySinh)";
            SqlCommand cmd = new SqlCommand(sqlInsert, con);
            cmd.Parameters.AddWithValue("MaDocGia", textBoxMaDG.Text);
            cmd.Parameters.AddWithValue("TenDocGia", textBoxTenDG.Text);
            cmd.Parameters.AddWithValue("DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("CMND", textBoxCMND.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textBoxNgaySinh.Text);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Mời nhập lại đúng các khóa");
            }

            HienThi();
        }

        private void buttonSuaDG_Click(object sender, EventArgs e)
        {
            string sqlEdit = "Update DocGia Set TenDocGia = @TenDocGia,DiaChi = @DiaChi,CMND = @CMND,NgaySinh = @NgaySinh where MaDocGia = @MaDocGia";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaDocGia", textBoxMaDG.Text);
            cmd.Parameters.AddWithValue("TenDocGia", textBoxTenDG.Text);
            cmd.Parameters.AddWithValue("DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("CMND", textBoxCMND.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textBoxNgaySinh.Text);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Mời nhập lại đúng các khóa");
            }

            HienThi();
        }

        private void buttonXoaDG_Click(object sender, EventArgs e)
        {
            string sqlDelete = "Delete from DocGia where MaDocGia = @MaDocGia";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("MaDocGia", textBoxMaDG.Text);
            cmd.Parameters.AddWithValue("TenDocGia", textBoxTenDG.Text);
            cmd.Parameters.AddWithValue("DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("CMND", textBoxCMND.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textBoxNgaySinh.Text);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Mời nhập lại đúng các khóa");
            }

            HienThi();
        }

        private void buttonTKDG_Click(object sender, EventArgs e)
        {
            string sqlFind = "Select * from DocGia where MaDocGia = @MaDocGia";
            SqlCommand cmd = new SqlCommand(sqlFind, con);
            cmd.Parameters.AddWithValue("MaDocGia", textBoxMaDG.Text);
            cmd.Parameters.AddWithValue("TenDocGia", textBoxTenDG.Text);
            cmd.Parameters.AddWithValue("DiaChi", textBoxDiaChi.Text);
            cmd.Parameters.AddWithValue("CMND", textBoxCMND.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textBoxNgaySinh.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewDG.DataSource = dt;
            dataGridViewDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
