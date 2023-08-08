using System.ComponentModel.DataAnnotations.Schema;

namespace My_shop_2.Models
{
    public class Admin
    {
        [ForeignKey("AdminId")]
        public int AId { get; set; }
        public string Pasword = "@F%^76TF&*hgff97tfDFo.<y/8d+9k*_D8";
        public string AName { get; set; }
        public decimal Sales { get; set; }
        public decimal Purchases { get; set; }
        public int countOfEmloyees { get; set; }
        public int countOfSales { get; set; }
    }
}
