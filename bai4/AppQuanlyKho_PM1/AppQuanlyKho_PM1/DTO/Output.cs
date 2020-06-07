using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DTO
{
    public class Output
    {
        public Output(string ID)
        {
            this.ID = ID;
        }
        public Output(DataRow row)
        {
            this.ID = row["ID"].ToString();
        }
        private string iD;
        private DateTime inputdate;

        public string ID { get => iD; set => iD = value; }
        public DateTime Inputdate { get => inputdate; set => inputdate = value; }
    }
}
