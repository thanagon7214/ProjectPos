using Microsoft.AspNetCore.Mvc;

namespace ProjectPos.Controllers
{
    public class FoodFactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FoodFactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public async Task<IActionResult> Index() {
            return View();
        }
    }
}
