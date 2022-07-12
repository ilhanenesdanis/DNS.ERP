using DTO;
using Microsoft.AspNetCore.Mvc;
using WebUI.ApiHandler;
using WebUI.Helpers;

namespace WebUI.Controllers
{
    public class BrandController : Controller
    {
        private readonly IApiHandler _apiHandler;
        private readonly IConfiguration _configuration;

        public BrandController(IConfiguration configuration, IApiHandler apiHandler)
        {
            _configuration = configuration;
            _apiHandler = apiHandler;
        }

        public IActionResult Index()
        {
            var BrandListUrl = _configuration["UrlVariable"] + UrlHelpers.GetAllBrand;
            var BrandList = _apiHandler.GetApi<ResultDTO<BrandDTO>>(BrandListUrl);

            return View(BrandList);
        }
        public JsonResult BrandAdd(string Name)
        {
            BrandDTO brandDTO = new BrandDTO()
            {
                Name = Name
            };
            var BrandAddUrl = _configuration["UrlVariable"] + UrlHelpers.AddNewBrand;
            var AddBrand = _apiHandler.PostApi<ResultDTO<BrandDTO>>(brandDTO, BrandAddUrl);

            return Json(new { success = "İşlem Başarılı", status = true, data = AddBrand.Data });
        }
        public JsonResult GetByBrandId(int id)
        {
            ResultDTO<BrandDTO> Brand = GetByIdBrand(id);
            return Json(new { succes = Brand.Message, status = Brand.Status, data = Brand.Data });
        }

        private ResultDTO<BrandDTO> GetByIdBrand(int id)
        {
            var brandUrl = _configuration["UrlVariable"] + UrlHelpers.GetByBrandId + id;
            var Brand = _apiHandler.GetApi<ResultDTO<BrandDTO>>(brandUrl);
            return Brand;
        }

        public JsonResult Update(BrandDTO brand)
        {
            ResultDTO<BrandDTO> Update = BrandUpdate(brand);
            return Json(new { succes = Update.Message, status = Update.Status });
        }

        private ResultDTO<BrandDTO> BrandUpdate(BrandDTO brand)
        {
            var brandUrl = _configuration["UrlVariable"] + UrlHelpers.UpdateBrand;
            var Update = _apiHandler.PostApi<ResultDTO<BrandDTO>>(brand, brandUrl);
            return Update;
        }

        public JsonResult ChangeStatus(int id)
        {
            var Brand = GetByIdBrand(id);
            if (Brand != null)
            {
                Brand.Data.Status = Brand.Data.Status == true ? false : true;
                var updatedBrand = BrandUpdate(Brand.Data);
                return Json(new { success = updatedBrand.Message, status = updatedBrand.Status, data = updatedBrand.Data });
            }
            return Json(new { success = Brand.Message, status = Brand.Status, data = Brand.Data });
        }
    }
}
