using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Mailling:Base
    {
        public int? DepartmentId { get; set; }
        public int? PersonnelId { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }

    }
}
