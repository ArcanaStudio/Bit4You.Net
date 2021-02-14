namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class MarketSummaryItem
    {
        public string Market { get; set; }
        public float MarketCap { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public float Volume { get; set; }
        public float Last { get; set; }
        public float PreviousDay { get; set; }
        public float Bid { get; set; }
        public float Ask { get; set; }
        public float Open { get; set; }
    }
}
