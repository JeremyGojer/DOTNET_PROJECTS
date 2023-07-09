using Microsoft.EntityFrameworkCore;
using ApiApp1.Models;

namespace Happy_Marriage.Utilities
{
    public class DBEntityContext:DbContext
    {
        public DbSet<Student> Student { get; set; }
        

        //to configure the database connection externally from program.cs and appsettings.json
        public DBEntityContext(DbContextOptions<DBEntityContext> options) : base(options) { 
        }

    }
}
