namespace Net.Arcanastudio.Bit4You.Model.Responses.Portfolio
{
    public class PorfolioListResponse
    {
        public PortfolioItem[] Items { get; set; }
        public float Wallet { get; set; }
    }

    public class PortfolioItem
    {
        public int Id { get; set; }
        public string BaseIso { get; set; }
        public string Market { get; set; }
        public float Invested { get; set; }
        public float Quantity { get; set; }
        public int OpenTime { get; set; }
    }

}
