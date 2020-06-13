using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DTO
{
    public class Role
    {
        public Role(string unitName)
        {
            this.RoleName = unitName;
        }

        public Role(DataRow row)
        {
            this.RoleName = row["Displayname"].ToString();
        }

        private string unitName;

        public string RoleName { get => unitName; set => unitName = value; }
    }
}
