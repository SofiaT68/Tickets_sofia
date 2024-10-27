using Microsoft.EntityFrameworkCore;

namespace TicketsManager
{
    class ApplicationContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Ticket.db");
        }
    }
}
