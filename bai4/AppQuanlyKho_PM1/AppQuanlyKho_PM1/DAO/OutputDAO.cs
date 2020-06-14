using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DAO
{
    public class OutputDAO
    {
        private static OutputDAO instance;

        public static OutputDAO Instance


        {
            get { if (instance == null) instance = new OutputDAO(); return OutputDAO.instance; }
            private set { OutputDAO.instance = value; }
        }

        private OutputDAO() { }

        public bool InsertOutput(string id, DateTime dateoutput)
        {
            string query = string.Format("insert into Outputs values (N'{0}','{1}-{2}-{3}')", id, dateoutput.Month, dateoutput.Day, dateoutput.Year);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateOutput(string id, DateTime dateoutput, string idold)
        {

            string query = string.Format("update Outputs set ID=N'{0}',Dateoutput='{1}-{2}-{3}' where ID=N'{4}'", id, dateoutput.Month, dateoutput.Day, dateoutput.Year, idold);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteOutput(string ID)
        {

            string query = string.Format("delete Outputs where ID='{0}'", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
