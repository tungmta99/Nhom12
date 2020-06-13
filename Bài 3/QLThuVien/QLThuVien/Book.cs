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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        SqlConnection con;


        public void HienThi()
        {
            string sqlSelect = "Select * from Sach";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewBook.DataSource = dt;
            dataGridViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Book_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void buttonAddSach_Click(object sender, EventArgs e)
        {
            string sqlInsert = "Insert into Sach Values (@MaSach, @TenSach, @MaTheLoai, @MaNXB, @NamXuatBan, @TacGia)";
            SqlCommand cmd = new SqlCommand(sqlInsert, con);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("TenSach", textBoxTenSach.Text);
            cmd.Parameters.AddWithValue("MaTheLoai", textBoxMaTheLoai.Text);
            cmd.Parameters.AddWithValue("MaNXB", textBoxMaNXB.Text);
            cmd.Parameters.AddWithValue("NamXuatBan", textBoxNamXB.Text);
            cmd.Parameters.AddWithValue("TacGia", textBoxTacGia.Text);
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

        private void buttonSuaSach_Click(object sender, EventArgs e)
        {
            string sqlEdit = "Update Sach Set TenSach = @TenSach, MaTheLoai = @MaTheLoai, MaNXB = @MaNXB, NamXuatBan = @NamXuatBan, TacGia = @TacGia where MaSach = @MaSach";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("TenSach", textBoxTenSach.Text);
            cmd.Parameters.AddWithValue("MaTheLoai", textBoxMaTheLoai.Text);
            cmd.Parameters.AddWithValue("MaNXB", textBoxMaNXB.Text);
            cmd.Parameters.AddWithValue("NamXuatBan", textBoxNamXB.Text);
            cmd.Parameters.AddWithValue("TacGia", textBoxTacGia.Text);
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

        private void buttonXoaSach_Click(object sender, EventArgs e)
        {
            string sqlDelete = "Delete from Sach where MaSach = @MaSach";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("TenSach", textBoxTenSach.Text);
            cmd.Parameters.AddWithValue("MaTheLoai", textBoxMaTheLoai.Text);
            cmd.Parameters.AddWithValue("MaNXB", textBoxMaNXB.Text);
            cmd.Parameters.AddWithValue("NamXuatBan", textBoxNamXB.Text);
            cmd.Parameters.AddWithValue("TacGia", textBoxTacGia.Text);
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

        private void buttonTimKiemSach_Click(object sender, EventArgs e)
        {
            string sqlFind = "Select * from Sach where MaSach = @MaSach";
            SqlCommand cmd = new SqlCommand(sqlFind, con);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("TenSach", textBoxTenSach.Text);
            cmd.Parameters.AddWithValue("MaTheLoai", textBoxMaTheLoai.Text);
            cmd.Parameters.AddWithValue("MaNXB", textBoxMaNXB.Text);
            cmd.Parameters.AddWithValue("NamXuatBan", textBoxNamXB.Text);
            cmd.Parameters.AddWithValue("TacGia", textBoxTacGia.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewBook.DataSource = dt;
            dataGridViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
