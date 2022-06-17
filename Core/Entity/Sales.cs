using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Sales : Base
    {
        public int ProductId { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal KDV { get; set; }
        public int MemberId { get; set; }
        public int PersonnelId { get; set; }
    }
}
