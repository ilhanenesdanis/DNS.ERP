using Core.Entity;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class PersonnelSalesRepository : Repository<PersonnelSales>, IPersonnelSalesRepository
    {
        public PersonnelSalesRepository(Context context) : base(context)
        {
        }
    }
}
