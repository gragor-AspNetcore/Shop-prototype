using Microsoft.AspNetCore.Mvc;

namespace My_shop_2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
