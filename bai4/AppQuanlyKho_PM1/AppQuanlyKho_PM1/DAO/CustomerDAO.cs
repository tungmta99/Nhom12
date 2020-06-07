using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }

        public List<Customer> GetListCustomer()
        {
            List<Customer> pList = new List<Customer>();

            string query = "select * from Customer";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                pList.Add(customer);
            }

            return pList;
        }

        public bool InsertCustomer(string supplierName, string adress, string phone, string email, string moreInfo, DateTime contractDate)
        {
            string query = String.Format("insert into Customer values(N'{0}',N'{1}','{2}','{3}','{4}','{5}-{6}-{7}')", supplierName, adress, phone, email, moreInfo, contractDate.Month, contractDate.Day, contractDate.Year);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCustomer(string supplierName, string adress, string phone, string email, string moreInfo, DateTime contractDate, int id)
        {
            string query = String.Format("update Customer set Displayname=N'{0}',Adress=N'{1}',Phone='{2}',Email='{3}',MoreInfo=N'{4}',Contractdate='{5}-{6}-{7}' where ID={8}", supplierName, adress, phone, email, moreInfo, contractDate.Month, contractDate.Day, contractDate.Year, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCustomer(int id)
        {
            string query = String.Format("delete Customer where ID='{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
