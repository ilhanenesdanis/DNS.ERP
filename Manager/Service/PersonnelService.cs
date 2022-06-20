using Core.Entity;
using Core.IRepository;
using Core.IUnitOfWork;
using Manager.IService;

namespace Manager.Service
{
    public class PersonnelService : Service<Personnel>, IPersonnelService
    {
        public PersonnelService(IUnitOfWork unitOfWork, IRepository<Personnel> repository) : base(unitOfWork, repository)
        {
        }
    }
}
