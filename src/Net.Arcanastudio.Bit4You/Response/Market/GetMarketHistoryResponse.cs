using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Response.Generic;

namespace Net.Arcanastudio.Bit4You.Response.Market
{
    internal class GetMarketHistoryResponse : BaseListResponse<MarketHistoryItem>
    {
        public GetMarketHistoryResponse(List<MarketHistoryItem> items) : base(items)
        {
        }
    }

    internal class MarketHistoryItem : MarketSummaryItem
    {

    }
}
