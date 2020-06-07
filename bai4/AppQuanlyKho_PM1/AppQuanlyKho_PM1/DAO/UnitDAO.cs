using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1.DAO
{
    public class UnitDAO
    {
        private static UnitDAO instance;

        public static UnitDAO Instance

            
        {
            get { if (instance == null) instance = new UnitDAO(); return UnitDAO.instance; }
            private set { UnitDAO.instance = value; }
        }

        private UnitDAO() { }

        public List<Unit> GetListUnit()
        {
            List<Unit> UnitList = new List<Unit>();

            string query = "select * from Unit";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Unit unit = new Unit(item);
                UnitList.Add(unit);
            }

            return UnitList;
        }

        public bool InsertUnit(string unitName)
        {
            string query = string.Format("insert into Unit values (N'{0}')",unitName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateUnit(string unitName,int ID)
        {

            string query = string.Format("update Unit set DisplayName =N'{0}' where ID ={1}",unitName,ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteUnit(int ID)
        {

            string query = string.Format("delete Unit where ID='{0}'", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
