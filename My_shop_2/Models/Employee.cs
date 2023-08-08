using System.ComponentModel.DataAnnotations.Schema;

namespace My_shop_2.Models
{
    public class Employee
    {
        [ForeignKey("EmployeeId")]
        public int EId { get; set; }
        public string Password { get; set; }
        public string EName { get; set; }
        public string ESurName { get; set; }
        public decimal Salary { get; set; }
        public int CountOfSalesPerMonth { get; set; }
        public string JobTittle { get; set; }
        public DateTime YearOfBirth { get; set; }
        public DateTime YearOfStartWorking { get; set; }

    }
}
