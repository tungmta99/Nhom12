using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance


        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set { UserDAO.instance = value; }
        }

        public bool InsertUser(string displayname,string username,string password, string rolename)
        {
            string query = string.Format("exec  AddUserByN N'{0}',N'{1}',N'{2}',N'{3}'", displayname,username,password,rolename);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateUser(string displayname, string username, string password, string rolename,int ID)
        {

            string query = string.Format("exec  UpdateUserByN N'{0}',N'{1}',N'{2}',N'{3}',{4}", displayname, username, password, rolename,ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteUser(int ID)
        {

            string query = string.Format("delete User where ID='{0}'", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
