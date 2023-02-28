using BeeHive.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BeeHive.Data
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Hive> Hives { get; set; }
    }
}
