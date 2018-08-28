using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IdentityDb.API.Model
{
    public class IdentityContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:tokeyserver.database.windows.net,1433;Initial Catalog=TestWebApp_DbTest;Persist Security Info=False;User ID=fruitybrew;Password=k19061906!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }


    }
}
