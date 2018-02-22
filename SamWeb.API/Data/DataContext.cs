using Microsoft.EntityFrameworkCore;
using SamWeb.API.Models;

namespace SamWeb.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Log> Logs { get; set; }
        public DbSet<LogLine> LogLines { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Journal> Journals { get; set; }
    }
}