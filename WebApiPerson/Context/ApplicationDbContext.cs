using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
