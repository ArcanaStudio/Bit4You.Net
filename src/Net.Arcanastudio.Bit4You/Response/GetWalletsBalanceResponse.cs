using System.Collections.Generic;

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
