using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using My_shop_2.Models;
using System;

namespace My_shop_2.Controllers
{
    public class BasketController : Controller
    {
        public List<string> names = new List<string>();
       
        private readonly BasketModel _model;
        public BasketController(BasketModel basket) 
        {
            _model =  basket;
        }
        public IActionResult Index()
        {
            return View();
        }
         
        [HttpGet]
        public async Task Create(BasketModel basket,HttpRequest request, Product product,List<string> names)
        {
            var _ProductInBasket = await request.ReadFromJsonAsync<Product>();

            decimal _price;

            basket.ProductInBasket = _ProductInBasket.ProductName;

            basket.Price = _ProductInBasket.ProductPrice * _ProductInBasket.ProductCount;

            names.Add(_ProductInBasket.ProductName);
           _price = basket.Price;  
          
            
        }
        [HttpPut]
        public async Task Details(List<string> names, decimal _price, HttpResponse response, HttpContext context ) 
        {
            await context.Response.WriteAsJsonAsync(names);
            await context.Response.WriteAsJsonAsync(_price);
        }
    }
}
