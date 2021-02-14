using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Market;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Wallet
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
