using Microsoft.AspNetCore.Mvc;
using WebUI.ApiHandler;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IApiHandler _apiHandler;
        private readonly IConfiguration _configuration;

        public CategoryController(IConfiguration configuration, IApiHandler apiHandler)
        {
            _configuration = configuration;
            _apiHandler = apiHandler;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
