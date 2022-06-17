using Core.Entity;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class PersonnelRepository : Repository<Personnel>, IPersonnelRepository
    {
        public PersonnelRepository(Context context) : base(context)
        {
        }
    }
}
