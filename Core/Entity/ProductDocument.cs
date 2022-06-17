using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class ProductDocument:Base
    {
        public int ProductId { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }

    }
}
