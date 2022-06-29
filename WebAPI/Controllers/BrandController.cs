
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
    public class BrandController : Controller
    {
        private readonly IBrandService _brand;

        public BrandController(IBrandService brand)
        {
            _brand = brand;
        }
        #region Tüm Marka Kayıtlarını Getirir
        [HttpGet]
        [Route("GetAllBrand")]
        public JsonResult GetAllBrand()
        {
            var BrandList = _brand.GetAll();
            ResultDTO<Brand> result;
            if (BrandList.Count > 0)
            {
                result = new ResultDTO<Brand>()
                {
                    DataList = BrandList,
                    Message = Messages.listedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<Brand>()
            {
                Message = Messages.listedError,
                Status = false
            };
            return Json(result);
        }
        #endregion
        #region Yeni Marka Ekler
        [HttpPost]
        [Route("AddNewBrand")]
        public JsonResult AddBrand(Brand brand)
        {
            _brand.Add(brand);
            ResultDTO<Brand> result;
            if (brand.Id > 0)
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
