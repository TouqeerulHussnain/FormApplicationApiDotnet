using FormApplicationApiDotNet.Configuration;
using FormApplicationApiDotNet.Model;
using Microsoft.EntityFrameworkCore;

namespace FormApplicationApiDotNet.ApiDbContext
{
    public class FormApiDbContext:DbContext
    {
        public FormApiDbContext(DbContextOptions option): base(option)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new PersonConfiguration().Configure(modelBuilder.Entity<Person>());
            
        }

        public DbSet<Person>   Persons { get; set; }
    }
}
