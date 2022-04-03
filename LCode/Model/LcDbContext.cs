using Microsoft.EntityFrameworkCore;

namespace LCode.Model {
    public class LcDbContext : DbContext,  ILcDbContext{
        public LcDbContext() {
        }
        public LcDbContext(DbContextOptions<LcDbContext> options) : base(options) {
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientType> ClientsTypes { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
