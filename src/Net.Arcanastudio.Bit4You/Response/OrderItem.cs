using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class OrderItem
    {
        [JsonPropertyName("txid")]
        public string Id { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("isOpen")]
        public bool IsOpen { get; set; }
        [JsonPropertyName("requested_rate")]
        public float? RequestedRate { get; set; }
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("base_quantity")]
        public float BaseQuantity { get; set; }
        [JsonPropertyName("blocked_quantity")]
        public float BlockedQuantity { get; set; }
        [JsonPropertyName("remaining")]
        public Remaining Remaining { get; set; }
        [JsonPropertyName("fee")]
        public Fee Fee { get; set; }
        [JsonPropertyName("position")]
        public Position Position { get; set; }
        [JsonPropertyName("open_time")]
        public int OpenTime { get; set; }
        [JsonPropertyName("update_time")]
        public int UpdateTime { get; set; }
    }

    public class Remaining
    {
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
    }

    public class Fee
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
    }

    public class Position
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }
        [JsonPropertyName("iso")]
        public object HistoryId { get; set; }
    }
}


