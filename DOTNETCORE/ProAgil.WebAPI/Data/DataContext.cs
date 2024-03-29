using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.model;

namespace ProAgil.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Evento> eventos { get; set; }
    }
}