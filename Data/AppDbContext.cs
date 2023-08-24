using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PjJoaoMarceloZenaro.Models;


namespace PjJoaoMarceloZenaro.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Psicologo>? Psicologos { get; set; }

    }
}