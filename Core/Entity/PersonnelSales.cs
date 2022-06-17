using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class PersonnelSales:Base
    {
        public int PersonnelId { get; set; }
        public int? SalesId { get; set; }
        public int? OrderId { get; set; }
        public int Price { get; set; }
    }
}
