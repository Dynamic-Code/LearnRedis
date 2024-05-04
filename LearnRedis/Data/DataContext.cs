using LearnRedis.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnRedis.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }  
    }
}
