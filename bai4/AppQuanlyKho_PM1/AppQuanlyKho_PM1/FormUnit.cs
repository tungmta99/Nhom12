using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanlyKho_PM1.DAO;

namespace AppQuanlyKho_PM1
{
    public partial class FormUnit : Form
    {
        BindingSource UnitList = new BindingSource();
        public FormUnit()
        {
            InitializeComponent();

            LoadUnit();

            AddBindingUnit();
        }

        void LoadUnit()
        {
            string query = "select ID, DisplayName as [Đơn vị] from Unit";

            dtgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvUnit.DataSource = UnitList;

            UnitList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        void AddBindingUnit()
        {
            textBoxUnitName.DataBindings.Add(new Binding("Text", dtgvUnit.DataSource, "Đơn vị", true, DataSourceUpdateMode.Never));
            labelIdUnit.DataBindings.Add(new Binding("Text", dtgvUnit.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                int ID  = Convert.ToInt32(labelIdUnit.Text);


                if (UnitDAO.Instance.DeleteUnit(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadUnit();

                }

                else
                {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string unitName = textBoxUnitName.Text;
            int id = Convert.ToInt32(labelIdUnit.Text);


            if (UnitDAO.Instance.UpdateUnit(unitName,id))
            {
                MessageBox.Show("Sửa thành công");

                LoadUnit();
            }

            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddUnit_Click(object sender, EventArgs e)
        {
            string unitName = textBoxUnitName.Text;
            

            if (UnitDAO.Instance.InsertUnit(unitName))
            {
                MessageBox.Show("Thêm thành công");

                LoadUnit();
            }

            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSreachUnit.Text;

            string query = string.Format("select ID, DisplayName as [Đơn vị] from Unit where DisplayName like N'%{0}%'", keyword);

            dtgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvUnit.DataSource = UnitList;

            UnitList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
