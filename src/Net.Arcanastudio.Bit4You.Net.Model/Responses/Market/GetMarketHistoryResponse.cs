using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class GetMarketHistoryResponse : BaseListResponse<MarketHistoryItem>
    {
        public GetMarketHistoryResponse(List<MarketHistoryItem> items) : base(items)
        {
        }
    }

    public class MarketHistoryItem : MarketSummaryItem
    {

    }
}
