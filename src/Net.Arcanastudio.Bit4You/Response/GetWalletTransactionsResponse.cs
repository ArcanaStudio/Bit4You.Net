using System.Collections.Generic;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class GetWalletTransactionsResponse : BaseListResponse<WalletTransactionsItem>
    {
        public GetWalletTransactionsResponse(List<WalletTransactionsItem> items) : base(items)
        {
        }
    }
}
