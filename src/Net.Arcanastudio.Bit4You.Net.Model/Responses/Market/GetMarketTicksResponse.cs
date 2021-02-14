using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class GetMarketTicksResponse : BaseListResponse<MarketTickItem>
    {
        public GetMarketTicksResponse(List<MarketTickItem> items) : base(items)
        {
        }
    }

    public class MarketTickItem : MarketSummaryItem
    {

    }
}
