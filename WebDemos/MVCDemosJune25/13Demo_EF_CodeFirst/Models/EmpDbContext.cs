using Microsoft.EntityFrameworkCore;

namespace _13Demo_EF_CodeFirst.Models
{
    public class EmpDbContext:DbContext
    {
        public DbSet<Emp> emps { get; set; }
        public EmpDbContext(DbContextOptions options):base(options)
        {
        }         
    }
}
