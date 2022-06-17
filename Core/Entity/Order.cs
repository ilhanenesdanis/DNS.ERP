using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Order : Base
    {
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNote { get; set; }
        public string OrderNo { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal KDV { get; set; }
        public int PersonnelId { get; set; }

    }
}
