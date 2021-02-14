namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class GetMarketOrderbookResponse
    {
        public string Market { get; set; }
        public string Id { get; set; }
        public string PrevId { get; set; }
        public AskResponse[] Ask { get; set; }
        public BidResponse[] Bid { get; set; }
    }

    public class AskResponse
    {
        public float Quantity { get; set; }
        public float Rate { get; set; }
        public int Index { get; set; }
    }

    public class BidResponse
    {
        public float Quantity { get; set; }
        public float Rate { get; set; }
        public int Index { get; set; }
    }

}
