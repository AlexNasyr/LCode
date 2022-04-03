namespace LCode.Model {
    public class Client {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClientType ClientType { get; set; }
    }
    public class ClientType {
        public int Id { get; set; }
        public string Name { get; set; }
        public Priority Priority { get; set; }
    }
}
