using Core.Entity;
using Core.IRepository;

namespace Data.Repository
{
    public class SalesRepository : Repository<Sales>, ISalesRepository
    {
        public SalesRepository(Context context) : base(context)
        {
        }
    }
}
