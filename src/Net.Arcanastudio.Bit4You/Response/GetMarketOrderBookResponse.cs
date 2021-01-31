using System.Collections.Generic;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class GetMarketOrderBookResponse : BaseListResponse<MarketOrderBookItem>
    {
        public GetMarketOrderBookResponse(List<MarketOrderBookItem> items) : base(items)
        {
        }
    }

    internal class MarketOrderBookItem : MarketSummaryItem
    {

    }
}
