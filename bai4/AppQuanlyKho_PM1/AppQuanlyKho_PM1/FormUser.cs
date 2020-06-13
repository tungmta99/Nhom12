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
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1
{
    public partial class FormUser : Form
    {
        BindingSource pList = new BindingSource();
        public FormUser()
        {
            InitializeComponent();

            LoadUser();

            LoadRoleList();

            AddBindingUser();

        }

        void LoadUser()
        {
            string query = "select Users.ID as [ID],Users.DisplayName as[Tên hiển thị],UserName as[Tên],Password as[Mật khẩu],UserRole.DisplayName as [Quyền] from Users,UserRole where Users.IdRole=UserRole.ID";

            dtgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvUser.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        void LoadRoleList()
        {
            List<Role> listRole = RoleDAO.Instance.GetListRole();
            comboBoxRole.DataSource = listRole;
            comboBoxRole.DisplayMember = "RoleName";
        }

        void AddBindingUser()
        {
            textBoxUserDisplayName.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            textBoxUserName.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            textBoxPassWord.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Mật khẩu", true, DataSourceUpdateMode.Never));
            comboBoxRole.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Quyền", true, DataSourceUpdateMode.Never));
            labelIdUSer.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string displayname = textBoxUserDisplayName.Text;
            string username = textBoxUserName.Text;
            string password = textBoxPassWord.Text;
            string rolename = comboBoxRole.Text;

            if (UserDAO.Instance.InsertUser(displayname,username,password,rolename))
            {
                MessageBox.Show("Thêm thành công");

                LoadUser();
            }

            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string displayname = textBoxUserDisplayName.Text;
            string username = textBoxUserName.Text;
            string password = textBoxPassWord.Text;
            string rolename = comboBoxRole.Text;
            int id = Convert.ToInt32(labelIdUSer.Text);

            if (UserDAO.Instance.UpdateUser(displayname, username, password, rolename,id))
            {
                MessageBox.Show("Sửa thành công");

                LoadUser();
            }

            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelIdUSer.Text);

            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                if (UserDAO.Instance.DeleteUser(id))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadUser();

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
