using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_shop_2.Models;

namespace My_shop_2.Data
{
    public class ApplicationDbContext :  DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Admin> admins;
        public DbSet<Product> products;
        public DbSet<User> users;
        public DbSet<Employee> employees;
    }
}