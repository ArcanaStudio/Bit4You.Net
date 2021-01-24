using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class PorfolioListResponse
    {
        [JsonPropertyName("items")]
        public PortfolioItem[] Items { get; set; }
        [JsonPropertyName("wallet")]
        public float Wallet { get; set; }
    }

    internal class PortfolioItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("base_iso")]
        public string BaseIso { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("invested")]
        public float Invested { get; set; }
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("open_time")]
        public int OpenTime { get; set; }
    }

}
