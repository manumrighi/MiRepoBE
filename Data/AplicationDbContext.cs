using APIAgenda.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIAgenda.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
