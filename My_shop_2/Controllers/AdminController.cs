using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using My_shop_2.Data;
using My_shop_2.Models;

namespace My_shop_2.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            
            return View( await _context.employees.ToListAsync());
        }

        public IActionResult SumOfSalaries()
        {
            decimal salary = 0;
            var Employee = _context.employees.ToList();
            if(Employee == null)
            {
                return NotFound();
            }
            foreach(var employee in Employee)
            {
                salary = salary + employee.Salary;
            }
            return View(salary);

        }
        public async Task<IActionResult> SalesDetails()
        {    
            decimal sales = 0;
            var Admins = await _context.admins.FirstOrDefaultAsync();
            var Employees =await _context.employees.ToListAsync();
            foreach(var employee in Employees)
            {
                sales = sales + employee.CountOfSalesPerMonth;
            } 
            sales = Admins.Sales;
            await _context.SaveChangesAsync();
            return View(sales);   
        }
        [HttpGet,HttpPost]
        public async Task<IActionResult> CreateEmployee( HttpRequest Hcontext, HttpResponse response)
        {
            var employee = await  Hcontext.ReadFromJsonAsync<Employee>();
            await _context.employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteEmployee(int? Id)
        {
            if(Id == null || _context.employees == null) 
            { 
                return NotFound(); 
            }
            var employee = await _context.employees.FirstOrDefaultAsync(m => m.EId == Id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var employee = await  _context.employees.FindAsync(Id);
            if (employee != null) 
            {
                _context.employees.Remove(employee);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
