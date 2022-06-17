using Core.Entity;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class MaillingRepository : Repository<Mailling>, IMaillingRepository
    {
        public MaillingRepository(Context context) : base(context)
        {
        }
    }
}
