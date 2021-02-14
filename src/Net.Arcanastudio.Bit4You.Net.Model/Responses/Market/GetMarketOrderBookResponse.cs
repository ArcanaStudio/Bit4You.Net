namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class GetMarketOrderBookResponse
    {
        public string Market { get; set; }
        public string Id { get; set; }
        public string PrevId { get; set; }
        public Ask[] Ask { get; set; }
        public Bid[] Bid { get; set; }
    }

    public class Ask
    {
        public float Quantity { get; set; }
        public float Rate { get; set; }
        public int I { get; set; }
    }

    public class Bid : Ask
    {
    }

}
