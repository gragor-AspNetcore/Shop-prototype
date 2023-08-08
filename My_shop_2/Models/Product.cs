using System.ComponentModel.DataAnnotations.Schema;

namespace My_shop_2.Models
{
    public class Product
    {
        [ForeignKey("ProductId")]
        public int PId { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public decimal ProductPrice { get; set; }


    }
}
