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
    public partial class FormInput : Form
    {
        BindingSource pList = new BindingSource();
        public FormInput()
        {
            InitializeComponent();

            LoadInput();

            AddBindingInput();
        }

        void LoadInput()
        {
            string query = String.Format("select Id as[Mã],DateInput as[Ngày] from Input");

            dtgvInput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvInput.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        void AddBindingInput()
        {
            textBoxInputID.DataBindings.Add(new Binding("Text", dtgvInput.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            dtpInputDate.DataBindings.Add(new Binding("Value", dtgvInput.DataSource, "Ngày", true, DataSourceUpdateMode.Never));
            labelIDold.DataBindings.Add(new Binding("Text", dtgvInput.DataSource, "Mã", true, DataSourceUpdateMode.Never));
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtgvInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxInputID.Text;
            DateTime dateinput = dtpInputDate.Value;
            if (InputDAO.Instance.InsertInput(id, dateinput))
            {
                MessageBox.Show("Thêm thành công");

                LoadInput();
            }

            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxInputID.Text;
            DateTime dateinput = dtpInputDate.Value;
            string idold = labelIDold.Text;

            if (InputDAO.Instance.UpdateInput(id, dateinput,idold))
            {
                MessageBox.Show("Sửa thành công");

                LoadInput();
            }

            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = labelIDold.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                if (InputDAO.Instance.DeleteInput(id))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadInput();

                }

                else
                {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
