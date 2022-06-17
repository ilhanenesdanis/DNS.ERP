using Core.Entity;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class OrderProductRepository : Repository<OrderProducts>, IOrderProductsRepository
    {
        public OrderProductRepository(Context context) : base(context)
        {
        }
    }
}
