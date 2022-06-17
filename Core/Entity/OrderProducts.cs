using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class OrderProducts:Base
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }
    }
}
