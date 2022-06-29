
using Core.Entity;
using DTO;
using Manager.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Constants;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #region Tüm Kategorileri Listeler
        [HttpGet]
        public JsonResult GetAllCategory()
        {
            var categoryList = _categoryService.GetAll();
            ResultDTO<Category> result;
            if (categoryList.Count > 0)
            {
                result = new ResultDTO<Category>()
                {
                    DataList = categoryList,
                    Message = Messages.listedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<Category>()
            {
                Message = Messages.listedError,
                Status = false
            };
            return Json(result);
        }
        #endregion
        #region Yeni Kategori Eklemesi Yapar
        [HttpPost]
        public JsonResult AddNewCategory(Category category)
        {
            _categoryService.Add(category);
            ResultDTO<Brand> result;
            if (category.Id > 0)
            {
                result = new ResultDTO<Brand>()
                {
                    Message = Messages.AddedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<Brand>()
            {
                Message = Messages.AddedError,
                Status = false
            };
            return Json(result);
        }
        #endregion
    }
}
