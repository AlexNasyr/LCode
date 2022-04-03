using Microsoft.EntityFrameworkCore;

namespace LCode.Model {
    public interface ILcDbContext {
        DbSet<Ticket> Tickets { get; set; }
        DbSet<TicketType> TicketTypes { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<ClientType> ClientsTypes { get; set; }
        DbSet<Channel> Channels { get; set; }
        DbSet<Priority> Priorities { get; set; }
    }
}
