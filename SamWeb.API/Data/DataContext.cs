using Microsoft.EntityFrameworkCore;

namespace SamWeb.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        
    }
}