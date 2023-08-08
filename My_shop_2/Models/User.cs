using System.ComponentModel.DataAnnotations.Schema;

namespace My_shop_2.Models
{
    public class User
    {
        [ForeignKey("UserId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
