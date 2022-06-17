using Core.Entity;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProductBrandRepository : Repository<ProductBrand>, IProductBrandRepository
    {
        public ProductBrandRepository(Context context) : base(context)
        {
        }
    }
}
