using AutoMapper;
using Core.Entity;
using DTO;
using Manager.IService;
using Manager.Security.Hashing;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Constants;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelController : Controller
    {
        private readonly IPersonnelService _personelService;
        private readonly IMapper _mapper;
        public PersonnelController(IPersonnelService personelService, IMapper mapper)
        {
            _personelService = personelService;
            _mapper = mapper;
        }
        [HttpGet]
        public JsonResult GetAllPersonnel()
        {
            var personnels = _mapper.Map<List<PersonnelDTO>>(_personelService.GetAll());
            ResultDTO<PersonnelDTO> result;
            if (personnels.Count > 0)
            {
                result = new ResultDTO<PersonnelDTO>()
                {
                    DataList = personnels,
                    Message = Messages.listedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<PersonnelDTO>()
            {
              
                Message = Messages.listedError,
                Status = false
            };
            return Json(result);
        }
        [HttpPost]
        public JsonResult AddNewPersonnel(AddPersonnelDTO addPersonnel)
        {
            byte[] passwordHash, passwordSalt;
            HashHelper.CreatePasswordHash(addPersonnel.Password, out passwordHash, out passwordSalt);
            Personnel personnel = new Personnel()
            {
                BirthDate = addPersonnel.BirthDate,
                CreateDate = DateTime.Now,
                Email = addPersonnel.Email,
                Image = addPersonnel.Image,
                Name = addPersonnel.Name,
                Status = true,
                Surname = addPersonnel.Surname,
                UpdateDate = DateTime.Now,
                PasswordHash=passwordHash,
                PasswordSalt=passwordSalt
            };
            _personelService.Add(personnel);
            ResultDTO<Personnel> result;
            if (personnel.Id > 0)
            {
                result = new ResultDTO<Personnel>()
                {
                    Message = Messages.AddedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<Personnel>()
            {
                Message = Messages.AddedError,
                Status = false
            };
            return Json(result);
        }
    }
}
