using System.Collections.Generic;
using System.Text.Json.Serialization;
using Net.Arcanastudio.Bit4You.Response.Generic;

namespace Net.Arcanastudio.Bit4You.Response.Portfolio
{
    internal class GetPortfolioHistoryListResponse : BaseListResponse<PortfolioHistoryResponseItem>
    {
        public GetPortfolioHistoryListResponse(List<PortfolioHistoryResponseItem> items) : base(items)
        {
        }
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
