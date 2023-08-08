using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_shop_2.Data;
using My_shop_2.Models;

namespace My_shop_2.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.products.ToListAsync());
        }

  

        public async Task<IActionResult> Create(HttpRequest request,HttpResponse response )
        {
            var product = await request.ReadFromJsonAsync<Product>();
            if (product == null)
            {
                return RedirectToAction(nameof(Create));
            }
             
            await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? Id,HttpRequest request)
        {
            if (Id == null || _context.products == null) 
            {
                return NotFound();
            }
            var productId = await _context.products.FirstOrDefaultAsync(m => m.PId == Id);
            if(productId == null)
            {
                return NotFound();
            }
            var product = await request.ReadFromJsonAsync<Product>();
            var EditedProduct = _context.products.FirstOrDefault(m => m.PId == Id);
            if (EditedProduct != null)
            {
                product = EditedProduct;
                await  _context.SaveChangesAsync();
            } 
            
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? Id) 
        {
            if(Id == null || _context.products == null) 
            {
                return NotFound();
            }
            var product = _context.products.FirstOrDefault(m => m.PId == Id);
            if(product == null)
            {
                return NotFound();
            }
            _context.Remove(product);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null || _context.products == null)
            {
                return NotFound();
            }
            var product = _context.products.FirstOrDefault(m => m.PId == Id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
