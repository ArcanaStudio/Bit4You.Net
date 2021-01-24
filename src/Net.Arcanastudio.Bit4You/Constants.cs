namespace Net.Arcanastudio.Bit4You
{
    internal static class Constants
    {
        internal static class Apis
        {
            internal const string GetToken = "https://auth.bit4you.io/token";
            internal const string GetUserInfo = "https://auth.bit4you.io/userinfo";
            internal const string GetMarketList = "/Market/List";
            internal const string GetMarketSummaries = "/Market/Summaries";
            internal const string GetMarketTicks = "/Market/Ticks";
            internal const string GetMarketOrderbooks = "/Market/Orderbook";
            internal const string GetMarketHistory = "/Market/History";
            internal const string GetWalletsBalance = "/Wallet/Balances";
            internal const string GetWalletTransactions = "/Wallet/Transactions";
            internal const string WalletWithdrawFunds = "/Wallet/Send";
            internal const string GetOrdersList = "/Order/List";
            internal const string GetOrderInfo = "/Order/Info";
            internal const string GetOrderPendingsList= "/Order/Pending";
            internal const string CreateOrder= "/Order/Create";
            internal const string CancelOrder= "/Order/Cancel";
            internal const string GetPortfolioList = "/Portfolio/List";
            internal const string GetPortfolioOpenOrderList = "/Portfolio/Open-Orders";
            internal const string GetPortfolioHistoryList = "/Portfolio/History";
            internal const string CreatePortfolioOrder = "/Portfolio/Create-Order";
            internal const string ClosePortfolioOrder = "/Portfolio/Close";
        }

        internal static class Base
        {
            internal const string BaseUrl = "https://www.bit4you.io/api/";
        }
    }
}
