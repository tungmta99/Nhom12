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
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        Database con = new Database();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public int temp = 0; //phan biet lua chon chuc nang
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            con.loadDataGridView(dataGridView1, "SELECT * FROM dbo.HocSinh");
            con.loadComboBox(comboBoxML, "SELECT MaLopHoc FROM dbo.LopHoc");
            btnLuu.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBoxMHS.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBoxTHS.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBoxGT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePickerNS.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBoxQQ.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            comboBoxML.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        public void OpenButtonClick()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnTimKiem.Enabled = true;
        }

        private void comboBoxML_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MaLop = comboBoxML.SelectedItem.ToString();
            con.loadDataGridView(dataGridView1, "SELECT * FROM dbo.HocSinh WHERE MaLopHoc=N'" + MaLop + "'");
        }
        public void Clear()
        {
            textBoxMHS.Clear();
            textBoxTHS.Clear();
            textBoxQQ.Clear();
            comboBoxGT.Text = "";
            dateTimePickerNS.Value = DateTime.Today;
            comboBoxML.Text = "";
        }
        public void ThemHocSinh()
        {
            try
            {
                string maHS = textBoxMHS.Text.TrimEnd();
                string tenHS = textBoxTHS.Text.TrimEnd();
                string gioiTinh = comboBoxGT.Text.TrimEnd();
                string queQuan = textBoxQQ.Text.TrimEnd();
                string ngaySinh = dateTimePickerNS.Value.ToShortDateString();
                string maLop = comboBoxML.Text.TrimEnd();

                if (maHS.Length != 0 && tenHS.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && maLop.Length != 0)
                {
                    bool check = con.Check(maHS, "SELECT ID_HS FROM dbo.HocSinh");
                    if (check == false)
                    {

                        string insert = "INSERT INTO dbo.HocSinh( ID_HS ,HoTen ,GioiTinh ,NgaySinh ,QueQuan ,MaLopHoc)"
                         + "VALUES(N'" + maHS + "', N'" + tenHS + "', N'" + gioiTinh + "', '" + ngaySinh + "', N'" + queQuan + "', N'" + maLop + "')";

                        
                        con.ThucThiKetNoi(insert);
                        MessageBox.Show("Thêm học sinh " + tenHS + " hoàn tất!");
                        dataGridView1.DataSource = null;
                        con.loadDataGridView(dataGridView1, "SELECT * FROM dbo.HocSinh WHERE ID_HS=N'" + maHS + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maHS + " đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SuaHocSinh()
        {
            try
            {
                string maHS = textBoxMHS.Text.TrimEnd();
                string tenHS = textBoxTHS.Text.TrimEnd();
                string gioiTinh = comboBoxGT.Text.TrimEnd();
                string queQuan = textBoxQQ.Text.TrimEnd();
                string ngaySinh = dateTimePickerNS.Value.ToShortDateString();
                string maLop = comboBoxML.Text.TrimEnd();

                if (maHS.Length != 0 && tenHS.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && maLop.Length != 0)
                {
                    bool check = con.Check(maHS, "SELECT ID_HS FROM dbo.HocSinh");
                    if (check == true)
                    {

                        string update = "UPDATE dbo.HocSinh SET HoTen = N'" + tenHS + "', GioiTinh = N'" + gioiTinh + "', NgaySinh='" + ngaySinh + "', QueQuan=N'" + queQuan + "', MaLopHoc=N'" + maLop + "' WHERE ID_HS=N'" + maHS + "'";
                        con.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa thông tin cho " + maHS + " hoàn tất!");
                        dataGridView1.DataSource = null;
                        con.loadDataGridView(dataGridView1, "SELECT * FROM dbo.HocSinh WHERE ID_HS=N'" + maHS + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maHS + " không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            temp = 1;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            temp = 2;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ys = MessageBox.Show("Bạn có muốn xóa " + textBoxTHS.Text.Trim() + " không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ys == DialogResult.Yes)
            {
                string del = "DELETE FROM dbo.HocSinh WHERE ID_HS=N'" + textBoxMHS.Text.Trim() + "'";
                con.ThucThiKetNoi(del);
                MessageBox.Show("Xóa " + textBoxMHS.Text.Trim() + " hoàn tất!");
                con.loadDataGridView(dataGridView1, "SELECT * FROM dbo.HocSinh");
                Clear();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnTimKiem.Enabled = true;

            textBoxMHS.Enabled = true;
            textBoxTHS.Enabled = true;
            textBoxQQ.ReadOnly = true;
            comboBoxGT.Enabled = false;
            comboBoxML.Enabled = false;
            dateTimePickerNS.Enabled = false;
        }

        private void tkMa_Click(object sender, EventArgs e)
        {
            textBoxTHS.Clear();
            string timkiem = "SELECT * FROM dbo.HocSinh WHERE ID_HS=N'" + textBoxMHS.Text.Trim() + "'";
            con.loadDataGridView(dataGridView1, timkiem);
        }

        private void tkTen_Click(object sender, EventArgs e)
        {
            textBoxMHS.Clear();
            string timkiem = "SELECT * FROM dbo.HocSinh WHERE HoTen LIKE N'%" + textBoxTHS.Text.TrimEnd() + "%'";
            con.loadDataGridView(dataGridView1, timkiem);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (temp)
            {
                case 0:
                    {
                        break;
                    }
                case 1: //Thêm
                    {
                        ThemHocSinh();
                        OpenButtonClick();//Mở lại các bị nút ẩn 
                        Clear();
                        break;
                    }
                case 2: //Sửa
                    {
                        SuaHocSinh();
                        OpenButtonClick();//Mở lại các bị nút ẩn 
                        Clear();
                        break;
                    }


                default: break;
            }
            
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;

            textBoxMHS.Enabled = true;
            textBoxTHS.Enabled = true;
            textBoxQQ.Enabled = true;
            comboBoxGT.Enabled = true;
            comboBoxML.Enabled = true;
            dateTimePickerNS.Enabled = true;
        }
    }
}
