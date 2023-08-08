using Microsoft.AspNetCore.Mvc;

namespace My_shop_2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
