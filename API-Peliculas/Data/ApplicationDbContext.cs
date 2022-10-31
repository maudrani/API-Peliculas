using API_Peliculas.Models;
using API_Peliculas.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace API_Peliculas.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
