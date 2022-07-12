
using Core.Entity;
using DTO;
using Manager.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
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
            brand.CreateDate = DateTime.Now;
            _brand.Add(brand);
            ResultDTO<Brand> result;
            if (brand.Id > 0)
            {
                result = new ResultDTO<Brand>()
                {
                    Data = brand,
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
        #region Id'Ye göre Marka getirir
        [HttpGet]
        [Route("GetByBrandId/{Id}")]
        public JsonResult GetByBrandId(int Id)
        {
            var Brand = _brand.GetById(Id);
            ResultDTO<Brand> result;
            if (Brand != null)
            {
                result = new ResultDTO<Brand>()
                {
                    Data = Brand,
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
        [HttpPost]
        [Route("UpdateBrand")]
        public JsonResult UpdateBrand(Brand brand)
        {
            var GetBrand=_brand.GetById(brand.Id);
            ResultDTO<Brand> result;
            if (GetBrand != null)
            {
                GetBrand.UpdateDate = DateTime.Now;
                GetBrand.Name = brand.Name;
                GetBrand.Status = brand.Status;
                _brand.Update(GetBrand);
                result = new ResultDTO<Brand>()
                {
                    Data = GetBrand,
                    Message = Messages.UpdatedSuccess,
                    Status = true
                };
                return Json(result);
            }
            result = new ResultDTO<Brand>()
            {
                Message = Messages.UpdatedError,
                Status = false
            };
            return Json(result);
        }
    }
}
