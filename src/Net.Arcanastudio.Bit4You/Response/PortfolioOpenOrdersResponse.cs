using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    internal class PortfolioOpenOrdersResponse
    {
        public PortfolioOpenOrderItem[] Items { get; set; }
    }

    public class PortfolioOpenOrderItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("execute_at")]
        public float ExecuteAt { get; set; }
        [JsonPropertyName("remaining_quantity")]
        public float RemainingQuantity { get; set; }
        [JsonPropertyName("remaining_iso")]
        public string RemainingIso { get; set; }
        [JsonPropertyName("isOpening")]
        public int IsOpening { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("baseCurrency")]
        public string BaseCurrency { get; set; }
        [JsonPropertyName("invested")]
        public float Invested { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("open_time")]
        public int OpenTime { get; set; }
        [JsonPropertyName("close_time")]
        public object CloseTime { get; set; }
    }

}
