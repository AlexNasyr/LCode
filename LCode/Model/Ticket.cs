namespace LCode.Model {
    public class Ticket {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TicketType TicketType { get; set; }
        public Channel Channel { get; set; }
        public Client Client { get; set; }
        public string Data { get; set; }
        public Ticket? Chain { get; set; }
    }
    public class TicketType {
        public int Id { get; set; }
        public string Name { get; set; }
        public Priority Priority { get; set; }
    }
}
