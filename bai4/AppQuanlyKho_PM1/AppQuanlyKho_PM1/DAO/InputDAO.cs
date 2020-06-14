using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DAO
{
    public class InputDAO
    {
        private static InputDAO instance;

        public static InputDAO Instance


        {
            get { if (instance == null) instance = new InputDAO(); return InputDAO.instance; }
            private set { InputDAO.instance = value; }
        }

        private InputDAO() { }

        public bool InsertInput(string id, DateTime dateinput)
        {
            string query = string.Format("insert into Input values (N'{0}','{1}-{2}-{3}')", id,dateinput.Month,dateinput.Day,dateinput.Year);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateInput(string id, DateTime dateinput,string idold)
        {

            string query = string.Format("update Input set ID=N'{0}',DateInput='{1}-{2}-{3}' where ID=N'{4}'", id, dateinput.Month,dateinput.Day,dateinput.Year,idold);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteInput(string ID)
        {

            string query = string.Format("delete Input where ID='{0}'", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
