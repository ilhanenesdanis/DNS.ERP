using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Meeting:Base
    {
        public int PersonnelId { get; set; }
        public int MemberId { get; set; }
        public string Message { get; set; }

    }
}
