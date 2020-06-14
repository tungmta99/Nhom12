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
    public partial class FormOutput1 : Form
    {
        BindingSource pList = new BindingSource();
        public FormOutput1()
        {
            InitializeComponent();

            LoadOutput();

            AddBindingOutput();
        }

        void LoadOutput()
        {
            string query = String.Format("select Id as[Mã],DateOutput as[Ngày] from Outputs");

            dtgvOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvOutput.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        void AddBindingOutput()
        {
            textBoxOutputID.DataBindings.Add(new Binding("Text", dtgvOutput.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            dtpOutputDate.DataBindings.Add(new Binding("Value", dtgvOutput.DataSource, "Ngày", true, DataSourceUpdateMode.Never));
            labelIDold.DataBindings.Add(new Binding("Text", dtgvOutput.DataSource, "Mã", true, DataSourceUpdateMode.Never));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxOutputID.Text;
            DateTime dateoutput = dtpOutputDate.Value;
            if (OutputDAO.Instance.InsertOutput(id, dateoutput))
            {
                MessageBox.Show("Thêm thành công");

                LoadOutput();
            }

            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxOutputID.Text;
            DateTime dateoutput = dtpOutputDate.Value;
            string idold = labelIDold.Text;

            if (OutputDAO.Instance.UpdateOutput(id, dateoutput, idold))
            {
                MessageBox.Show("Sửa thành công");

                LoadOutput();
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
                if (OutputDAO.Instance.DeleteOutput(id))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadOutput();

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
