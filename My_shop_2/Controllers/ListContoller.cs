using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_shop_2.Data;

namespace My_shop_2.Controllers
{
    public class ListContoller : Controller
    {
        private readonly ApplicationDbContext _context;
        public ListContoller(ApplicationDbContext context)
        {
            _context = context;
        }
      

        public async Task<IActionResult> Index()
        {
            return View(await _context.products.ToListAsync());
        }

        public async Task<IActionResult> Details(string? entername)
        {
            if(entername == null || _context.products == null) 
            {
                return NotFound();
            }
            var name = await _context.products.FirstOrDefaultAsync(m => m.ProductName == entername );
            if(name == null)
            {
                return NotFound();
            }
            return View(name);
        }
       
    }
}
