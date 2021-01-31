using System.Collections.Generic;

namespace Net.Arcanastudio.Bit4You.Response
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
