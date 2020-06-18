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
    public partial class frmTKB : Form
    {
        public frmTKB()
        {
            InitializeComponent();
        }
        Database con = new Database();
        private void frmTKB_Load(object sender, EventArgs e)
        {
            con.loadComboBox(comboBoxLop, "select MaLopHoc from LopHoc ");
            con.loadComboBox(comboBoxGV, "SELECT ID_GV FROM dbo.GiaoVien ");
        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tkb = "EXEC TKB @malop='" + comboBoxLop.Text.TrimEnd() + "'";
            con.loadDataGridView(dataGridViewTKB, tkb);
;        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnThem.Text == "Thêm")
            {
                comboBoxLop.Text = "";
                textBoxThu.Clear();
                textBoxTiet.Clear();
                comboBoxGV.Text = "";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Text = "Lưu";
            }                
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                try
                {
                    string malop = comboBoxLop.Text.Trim();
                    string magv = comboBoxGV.Text.Trim();
                    string thu = textBoxThu.Text.Trim();
                    string tiet = textBoxTiet.Text.Trim();
                    string mon = textBoxMonHoc.Text.Trim();

                    if (comboBoxLop.Text.Length != 0 && comboBoxGV.Text.Length != 0 && textBoxThu.Text.Length != 0 && textBoxTiet.Text.Length != 0)
                    {
                        bool check = con.Check(comboBoxLop.Text, "SELECT MaLopHoc FROM dbo.DayHoc WHERE Thu = N'" + thu + "' AND Tiet =N'" + tiet + "'");
                        if (check == false)
                        {
                            con.ThucThiKetNoi("INSERT dbo.DayHoc(MonHoc, ID_GV, MaLopHoc, Thu, Tiet) VALUES (N'" + mon + "', '" + magv + "', '" + malop + "', N'" + thu + "', N'" + tiet + "')");
                            MessageBox.Show("Thêm hoàn tất!");
                            con.loadDataGridView(dataGridViewTKB, "EXEC TKB @malop = '" + malop + "'");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm!" + textBoxThu.Text + " đã có tiết " + textBoxTiet + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy điền đủ thông tin!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
        }

        private void dataGridViewTKB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridViewTKB.CurrentRow.Index;
            textBoxThu.Text = dataGridViewTKB.Rows[i].Cells[0].Value.ToString();
            textBoxTiet.Text = dataGridViewTKB.Rows[i].Cells[1].Value.ToString();
            textBoxMonHoc.Text = dataGridViewTKB.Rows[i].Cells[2].Value.ToString();
            comboBoxGV.Text = dataGridViewTKB.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string malop = comboBoxLop.Text.Trim();
                string magv = comboBoxGV.Text.Trim();
                string thu = textBoxThu.Text.Trim();
                string tiet = textBoxTiet.Text.Trim();
                string mon = textBoxMonHoc.Text.Trim();

                if (comboBoxLop.Text.Length != 0 && comboBoxGV.Text.Length != 0 && textBoxThu.Text.Length != 0 && textBoxTiet.Text.Length != 0)
                {
                    bool check = con.Check(malop, "SELECT MaLopHoc FROM dbo.DayHoc");
                    if (check == true)
                    {

                        string update = "UPDATE dbo.DayHoc SET MonHoc = N'" + mon + "', ID_GV = N'" + magv + "', Thu=N'" + thu + "', Tiet=N'" + tiet + "' WHERE MaLopHoc=N'" + malop + "'";
                        con.ThucThiKetNoi(update);
                        MessageBox.Show("Sửa thông tin cho TKB hoàn tất!");
                        dataGridViewTKB.DataSource = null;
                        con.loadDataGridView(dataGridViewTKB, "EXEC TKB @malop = '" + malop + "'");

                    }
                    else
                    {
                        MessageBox.Show("Lớp học không tồn tại!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
