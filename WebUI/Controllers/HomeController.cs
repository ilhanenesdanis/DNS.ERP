using DTO;
using Microsoft.AspNetCore.Mvc;
using WebUI.ApiHandler;
using WebUI.Helpers;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiHandler _apiHandler;
        private readonly IConfiguration _configuration;

        public HomeController(IApiHandler apiHandler, IConfiguration configuration)
        {
            _apiHandler = apiHandler;
            _configuration = configuration;
        }

        //public IActionResult Index()
        //{
        //    var url = _configuration["UrlVariable"] + UrlHelpers.GetAllPersonnel;
        //    var result = _apiHandler.GetApi<ResultDTO<PersonnelDTO>>(url);
        //    return View();
        //}
        public IActionResult Dasboard()
        {
            return View();
        }
    }
}
