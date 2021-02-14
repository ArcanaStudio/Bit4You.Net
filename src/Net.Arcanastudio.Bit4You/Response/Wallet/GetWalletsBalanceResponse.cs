using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Response.Generic;
using Net.Arcanastudio.Bit4You.Response.Market;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class GetWalletsBalanceResponse : BaseListResponse<WalletsBalanceItem>
    {
        public GetWalletsBalanceResponse(List<WalletsBalanceItem> items) : base(items)
        {
        }
    }

    internal class WalletsBalanceItem : MarketSummaryItem
    {

    }
}
