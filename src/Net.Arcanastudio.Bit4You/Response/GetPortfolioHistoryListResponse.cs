using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class GetPortfolioHistoryListResponse
    {
        public PortfolioHistoryResponseItem[] Items { get; set; }
    }

    internal class PortfolioHistoryResponseItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("baseCurrency")]
        public string BaseCurrency { get; set; }
        [JsonPropertyName("invested")]
        public float Invested { get; set; }
        [JsonPropertyName("closed_amount")]
        public float ClosedAmount { get; set; }
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("fee")]
        public int Fee { get; set; }
        [JsonPropertyName("open_time")]
        public int OpenTime { get; set; }
        [JsonPropertyName("close_time")]
        public int CloseTime { get; set; }
    }

}
