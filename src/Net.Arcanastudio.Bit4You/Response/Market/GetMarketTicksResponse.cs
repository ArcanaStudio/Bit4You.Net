using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Response.Generic;

namespace Net.Arcanastudio.Bit4You.Response.Market
{
    internal class GetMarketTicksResponse : BaseListResponse<MarketTickItem>
    {
        public GetMarketTicksResponse(List<MarketTickItem> items) : base(items)
        {
        }
    }

    internal class MarketTickItem : MarketSummaryItem
    {

    }
}
