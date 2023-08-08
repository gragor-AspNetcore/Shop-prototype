using My_shop_2.Data;

namespace My_shop_2.Models
{
    public class BasketModel 
    {
       
        public decimal Price { get; set; }
        public int count { get; set; }

        public string ProductInBasket;
    }
}
