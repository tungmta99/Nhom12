using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DTO
{
    public class Unit
    {
        public Unit(string unitName)
        {
            this.UnitName = unitName;
        }

        public Unit(DataRow row)
        {
            this.UnitName = row["Displayname"].ToString();
        }

        private string unitName;

        public string UnitName { get => unitName; set => unitName = value; }
    }
}
