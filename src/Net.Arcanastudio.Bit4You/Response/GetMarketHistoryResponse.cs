using System.Collections.Generic;

namespace Net.Arcanastudio.Bit4You.Response
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
