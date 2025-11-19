using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models.Enities;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
