namespace LCode.Model {
    public class LcRepository : ILcRepository{
        private ILcDbContext _dbContext;
        public LcRepository() {
        }
        public LcRepository(ILcDbContext dbContext) { 
            _dbContext = dbContext;
        }
        public Task<LcResponce[]> GetQueries() {
            var tickets = from t in _dbContext.Tickets 
                          select new LcResponce { qId = t.Id, qDate = t.Date
                                        , qContent = t.Data
                                        , qAddTo = t.Chain.Id, qAddFromDate = t.Chain.Date
                                        , qClientName = t.Client.Name, qClientVeight = t.Client.ClientType.Priority.Value
                                        , qChannelName = t.Channel.Name, qChannelVeight = t.Channel.Priority.Value 
                                        , qTicketName = t.TicketType.Name, qTicketVeight = t.TicketType.Priority.Value
                          };
            return Task.FromResult(tickets.ToArray());
        }
    }
}
