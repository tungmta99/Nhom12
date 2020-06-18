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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        Database con = new Database();
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            con.loadDataGridView(dataGridView, "SELECT * FROM dbo.GiaoVien");
            btnLuu.Enabled = false;
        }
        public int temp = 0;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView.CurrentRow.Index;
            textBoxMGV.Text = dataGridView.Rows[i].Cells[0].Value.ToString();
            textBoxTGV.Text = dataGridView.Rows[i].Cells[1].Value.ToString();
            comboBoxGT.Text = dataGridView.Rows[i].Cells[2].Value.ToString();
            dateTimePickerNS.Text = dataGridView.Rows[i].Cells[3].Value.ToString();
            textBoxQQ.Text = dataGridView.Rows[i].Cells[4].Value.ToString();
            textBoxTD.Text = dataGridView.Rows[i].Cells[5].Value.ToString();
            textBoxSDT.Text = dataGridView.Rows[i].Cells[6].Value.ToString();
        }
        public void Clear()
        {
            textBoxMGV.Clear();
            textBoxTGV.Clear();
            textBoxQQ.Clear();
            comboBoxGT.Text = "";
            dateTimePickerNS.Value = DateTime.Today;
            textBoxTD.Clear();
            textBoxSDT.Clear();
        }
        public void OpenButton()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnTimKiem.Enabled = true;
        }
        public void ReadOnlyFasle()
        {
            textBoxMGV.Enabled = true;
            textBoxMGV.ReadOnly = false;
            textBoxTGV.Enabled = true;
            textBoxQQ.ReadOnly = false;
            comboBoxGT.Enabled = true;
            textBoxTD.Enabled = true;
            textBoxSDT.Enabled = true;
            dateTimePickerNS.Enabled = true;
        }
        public void ThemGiaoVien()
        {
            try
            {
                string maGV = textBoxMGV.Text.TrimEnd();
                string tenGV = textBoxTGV.Text.TrimEnd();
                string gioiTinh = comboBoxGT.Text.TrimEnd();
                string queQuan = textBoxQQ.Text.TrimEnd();
                string ngaySinh = dateTimePickerNS.Value.ToShortDateString();
                string trinhDo = textBoxTD.Text.TrimEnd();
                string sdt = textBoxSDT.Text.TrimEnd();

                if (maGV.Length != 0 && tenGV.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && trinhDo.Length != 0 && sdt.Length != 0)
                {
                    bool check = con.Check(maGV, "SELECT ID_GV FROM dbo.GiaoVien");
                    if (check == false)
                    {

                        string insert = "INSERT INTO dbo.GiaoVien( ID_GV ,HoTen ,GioiTinh ,NgaySinh ,QueQuan ,TrinhDo ,SDT)"
                        + "VALUES  ( N'" + maGV + "' , N'" + tenGV + "' , N'" + gioiTinh + "' , '" + ngaySinh + "' , N'" + queQuan + "' , N'" + trinhDo + "' , '" + sdt + "' )";
                        con.ThucThiKetNoi(insert);
                        MessageBox.Show("Thêm GV " + tenGV + " hoàn tất!");
                        dataGridView.DataSource = null;
                        con.loadDataGridView(dataGridView, "SELECT * FROM dbo.GiaoVien WHERE ID_GV=N'" + maGV + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maGV + " đã tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "");
            }
        }
        public void SuaGiaoVien()
        {
            try
            {
                string maGV = textBoxMGV.Text.TrimEnd();
                string tenGV = textBoxTGV.Text.TrimEnd();
                string gioiTinh = comboBoxGT.Text.TrimEnd();
                string queQuan = textBoxQQ.Text.TrimEnd();
                string ngaySinh = dateTimePickerNS.Value.ToShortDateString();
                string trinhDo = textBoxTD.Text.TrimEnd();
                string sdt = textBoxSDT.Text.TrimEnd();

                if (maGV.Length != 0 && tenGV.Length != 0 && gioiTinh.Length != 0 && queQuan.Length != 0 && trinhDo.Length != 0 && sdt.Length != 0)
                {
                    bool check = con.Check(maGV, "SELECT ID_GV FROM dbo.GiaoVien");
                    if (check == true)
                    {

                        string update = "UPDATE dbo.GiaoVien SET HoTen=N'" + tenGV + "' ,GioiTinh=N'" + gioiTinh + "' ,"
                            + "NgaySinh='" + ngaySinh + "' ,QueQuan=N'" + queQuan + "' ,TrinhDo=N'" + trinhDo + "' ,SDT=N'" + sdt + "' WHERE ID_GV=N'" + maGV + "'";
                        con.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa thông tin GV: " + maGV + " hoàn tất!");
                        dataGridView.DataSource = null;
                        con.loadDataGridView(dataGridView, "SELECT * FROM dbo.GiaoVien WHERE ID_GV=N'" + maGV + "'");

                    }
                    else
                    {
                        MessageBox.Show("Mã " + maGV + " Không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi!", "");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Clear();
            temp = 1;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
            dataGridView.DataSource = null;
            con.loadDataGridView(dataGridView, "SELECT * FROM dbo.GiaoVien");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            temp = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnTimKiem.Enabled = false;
            textBoxMGV.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ys = MessageBox.Show("Bạn có muốn xóa " + textBoxTGV.Text.Trim() + " không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ys == DialogResult.Yes)
            {
                string del = "DELETE FROM dbo.GiaoVien WHERE ID_GV=N'" + textBoxMGV.Text.TrimEnd() + "'";
                con.ThucThiKetNoi(del);
                MessageBox.Show("Xóa " + textBoxMGV.Text.TrimEnd() + " hoàn tất!");
                con.loadDataGridView(dataGridView, "SELECT * FROM dbo.GiaoVien");
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

            textBoxMGV.Enabled = true;
            textBoxTGV.Enabled = true;
            textBoxQQ.ReadOnly = true;
            comboBoxGT.Enabled = false;
            textBoxTD.Enabled = false;
            textBoxSDT.Enabled = false;
            dateTimePickerNS.Enabled = false;
        }

        private void tkMa_Click(object sender, EventArgs e)
        {
            textBoxTGV.Clear();
            string timkiem = "SELECT * FROM dbo.GiaoVien WHERE ID_GV=N'" + textBoxMGV.Text.TrimEnd() + "'";
            con.loadDataGridView(dataGridView, timkiem);
        }

        private void tkTen_Click(object sender, EventArgs e)
        {
            textBoxMGV.Clear();
            string timkiem = "SELECT * FROM dbo.GiaoVien WHERE HoTen LIKE N'%" + textBoxTGV.Text.TrimEnd() + "%'";
            con.loadDataGridView(dataGridView, timkiem);
        }
        private void exitSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenButton();
            ReadOnlyFasle();
            con.loadDataGridView(dataGridView, "SELECT * FROM dbo.GiaoVien");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (temp)
            {
                case 0: break;
                case 1:
                    {
                        ThemGiaoVien();
                        OpenButton();
                        ReadOnlyFasle();
                        break;
                    }
                case 2:
                    {
                        SuaGiaoVien();
                        OpenButton();
                        ReadOnlyFasle();
                        break;
                    }
                default: break;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
