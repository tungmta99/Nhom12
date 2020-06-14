using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLThuVien
{
    public partial class BorrowAndGiveBack : Form
    {
        public BorrowAndGiveBack()
        {
            InitializeComponent();
        }

        SqlConnection con;

        

        private void BorrowAndGiveBack_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QuanLyThuVien"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        public void HienThi()
        {
            string sqlSelect = "Select * from MuonTra";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewBAGB.DataSource = dt;
            dataGridViewBAGB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

      

        private void BorrowAndGiveBack_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        
        private void buttonAddDG_Click(object sender, EventArgs e)
        {
            string sqlInsert = "Insert into DocGia Values (@MaMuonTra, @MaSach, @SoThe, @Datra, @NgayMuon, @NgayTra)";
            SqlCommand cmd = new SqlCommand(sqlInsert, con);
            cmd.Parameters.AddWithValue("MaMuonTra", textBoxMaMuonTra.Text);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("SoThe", textBoxSoThe.Text);
            cmd.Parameters.AddWithValue("DaTra", textBoxTinhTrang.Text);
            cmd.Parameters.AddWithValue("NgayMuon", textBoxNgayMuon.Text);
            cmd.Parameters.AddWithValue("NgayTra", textBoxNgayTra.Text);
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

        private void textBoxNamXB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonXoaDG_Click(object sender, EventArgs e)
        {
            string sqlDelete = "Delete from MuonTra where MaMuonTra = @MaMuonTra";
            SqlCommand cmd = new SqlCommand(sqlDelete, con);
            cmd.Parameters.AddWithValue("MaMuonTra", textBoxMaMuonTra.Text);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("SoThe", textBoxSoThe.Text);
            cmd.Parameters.AddWithValue("DaTra", textBoxTinhTrang.Text);
            cmd.Parameters.AddWithValue("NgayMuon", textBoxNgayMuon.Text);
            cmd.Parameters.AddWithValue("NgayTra", textBoxNgayTra.Text);
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
            string sqlEdit = "Update DocGia Set MaSach = @MaSach, SoThe = @SoThe, DaTra = @Datra, NgayMuon = @NgayMuon, NgayTra = @NgayTra where MaMuonTra = @MaMuonTra";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("MaMuonTra", textBoxMaMuonTra.Text);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("SoThe", textBoxSoThe.Text);
            cmd.Parameters.AddWithValue("DaTra", textBoxTinhTrang.Text);
            cmd.Parameters.AddWithValue("NgayMuon", textBoxNgayMuon.Text);
            cmd.Parameters.AddWithValue("NgayTra", textBoxNgayTra.Text);
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
            string sqlFind = "Select * from MuonTra where MaMuonTra = @MaMuonTra";
            SqlCommand cmd = new SqlCommand(sqlFind, con);
            cmd.Parameters.AddWithValue("MaMuonTra", textBoxMaMuonTra.Text);
            cmd.Parameters.AddWithValue("MaSach", textBoxMaSach.Text);
            cmd.Parameters.AddWithValue("SoThe", textBoxSoThe.Text);
            cmd.Parameters.AddWithValue("DaTra", textBoxTinhTrang.Text);
            cmd.Parameters.AddWithValue("NgayMuon", textBoxNgayMuon.Text);
            cmd.Parameters.AddWithValue("NgayTra", textBoxNgayTra.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridViewBAGB.DataSource = dt;
            dataGridViewBAGB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
