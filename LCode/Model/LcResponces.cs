namespace LCode.Model {
    public class LcResponce {
        public int qId { get; set; }
        public DateTime qDate { get; set; }
        public string qContent { get; set; }
        public int? qAddTo { get; set; }
        public DateTime? qAddFromDate { get; set; }
        public string qClientName { get; set; }
        public int qClientVeight { get; set; }
        public string qChannelName { get; set; }
        public int qChannelVeight { get; set; }
        public string qTicketName { get; set; }
        public int qTicketVeight { get; set; }
    }
}
