using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class ProductStock:Base
    {
        public int ProductId { get; set; }
        public int Stock { get; set; }

    }
}
