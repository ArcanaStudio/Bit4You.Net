namespace Net.Arcanastudio.Bit4You.Model.Responses.Orders
{
    public class OrderItem
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Market { get; set; }
        public bool IsOpen { get; set; }
        public float? RequestedRate { get; set; }
        public float Quantity { get; set; }
        public float BaseQuantity { get; set; }
        public float BlockedQuantity { get; set; }
        public Remaining Remaining { get; set; }
        public Fee Fee { get; set; }
        public Position Position { get; set; }
        public int OpenTime { get; set; }
        public int UpdateTime { get; set; }
    }

    public class Remaining
    {
        public float Quantity { get; set; }
        public string Iso { get; set; }
    }

    public class Fee
    {
        public int Quantity { get; set; }
        public string Iso { get; set; }
    }

    public class Position
    {
        public int? Id { get; set; }
        public object HistoryId { get; set; }
    }
}


