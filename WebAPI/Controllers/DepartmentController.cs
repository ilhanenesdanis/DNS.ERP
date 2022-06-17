using Core.DTO;
using Core.Entity;
using Manager.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Constants;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        #region Tüm Departmanları Listeler
        [HttpGet]
        public JsonResult GetAllDepartment()
        {
            var DepartmentList = _departmentService.GetAll();
            ResultDTO<Department> result; 
            if (DepartmentList.Count > 0)
            {
                result = new ResultDTO<Department>()
                {
                    DataList = DepartmentList,
                    Message = Messages.listedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<Department>()
            {
                Message = Messages.listedError,
                Status = false
            };
            return Json(result);
        }
        #endregion
        #region Yeni Departman Ekler
        [HttpPost]
        public JsonResult AddNewDepartment(Department department)
        {
            _departmentService.Add(department);
            ResultDTO<Department> result;
            if (department.Id > 0)
            {
                result = new ResultDTO<Department>()
                {
                    Message = Messages.AddedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<Department>()
            {
                Message = Messages.AddedError,
                Status = false
            };
            return Json(result);
        }
        #endregion
    }
}
