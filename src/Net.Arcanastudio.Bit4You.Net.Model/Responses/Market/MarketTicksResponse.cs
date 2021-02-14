namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class MarketTicksResponse
    {
        public int Time { get; set; }
        public float Open { get; set; }
        public float Close { get; set; }
        public float Low { get; set; }
        public float High { get; set; }
        public float Volume { get; set; }
        public float MarketVolume { get; set; }
    }
}
