using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class MemberOrderHistory:Base
    {
        public int MemberId { get; set; }
        public int OrderId { get; set; }
    }
}
