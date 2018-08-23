using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestMigrationDb.API.Model
{
    public class RecordContext : DbContext
    {
        public DbSet<Record> Records { get; set; }

        public RecordContext(DbContextOptions<RecordContext> options)
            : base(options)
        {
            
        }
    }
}
