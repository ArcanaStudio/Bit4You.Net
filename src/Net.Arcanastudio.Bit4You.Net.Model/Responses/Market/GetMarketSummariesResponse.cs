using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class GetMarketSummariesResponse : BaseListResponse<MarketHistoryResponseItem>
    {
        public GetMarketSummariesResponse(List<MarketHistoryResponseItem> items) : base(items)
        {
        }
    }

    public class MarketHistoryResponseItem
    {
        public string Id { get; set; }
        public int Time { get; set; }
        public float Quantity { get; set; }
        public float Rate { get; set; }
        public bool Buy { get; set; }
    }
}
