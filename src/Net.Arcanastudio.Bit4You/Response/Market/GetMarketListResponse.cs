using System.Collections.Generic;
using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Response.Generic;

namespace Net.Arcanastudio.Bit4You.Response.Market
{
    internal class GetMarketListResponse : BaseListResponse<MarketResponseItem>
    {
        public GetMarketListResponse(List<MarketResponseItem> items) : base(items)
        {
        }
    }

    internal class MarketResponseItem
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("precision")]
        public int Precision { get; set; }
        [JsonPropertyName("value")]
        public float Value { get; set; }
        [JsonPropertyName("change")]
        public float Change { get; set; }
        [JsonPropertyName("spread")]
        public float Spread { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
    }
}
