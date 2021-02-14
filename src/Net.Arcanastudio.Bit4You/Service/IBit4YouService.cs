using System.Threading.Tasks;
using Net.Arcanastudio.Bit4You.Payload.Market;
using Net.Arcanastudio.Bit4You.Payload.Orders;
using Net.Arcanastudio.Bit4You.Payload.Portfolio;
using Net.Arcanastudio.Bit4You.Payload.Token;
using Net.Arcanastudio.Bit4You.Payload.Wallet;
using Net.Arcanastudio.Bit4You.Response;
using Net.Arcanastudio.Bit4You.Response.GetUserInfo;
using Net.Arcanastudio.Bit4You.Response.Market;
using Net.Arcanastudio.Bit4You.Response.Orders;
using Net.Arcanastudio.Bit4You.Response.Portfolio;
using Net.Arcanastudio.Bit4You.Response.Token;

namespace Net.Arcanastudio.Bit4You.Service
{
    internal interface IBit4YouService
    {
        Task<GetTokenResponse> GetToken(GetTokenPayload payload);
        Task<GetMarketListResponse> GetMarketList();
        Task<GetMarketSummariesResponse> GetMarketSummaries();
        Task<GetMarketTicksResponse> GetMarketTicks(MarketTicksPayload payload);
        Task<GetMarketOrderBookResponse> GetMarketOrderBook(GetMarketOrderBookPayload payload);
        Task<GetMarketHistoryResponse> GetMarketHistory(MarketHistoryPayload payload);
        Task<GetWalletsBalanceResponse> GetWalletsBalance(WalletsBalancesPayload payload);
        Task<GetWalletTransactionsResponse> GetWalletTransactions(WalletTransactionsPayload payload);
        Task<WalletWithdrawFundsResponse> WalletWithdrawFunds(WalletWithdrawFundsPayload payload);
        Task<GetOrdersListResponse> GetOrdersList(OrdersListPayload payload);
        Task<OrderItem> GetOrderInfo(OrderInfoPayload payload);
        Task<GetOrdersPendingResponse> GetOrdersPending(OrderInfoPayload payload);
        Task<OrderItem> CreateOrder(CreateOrderPayload payload);
        Task<CancelOrderResponse> CancelOrder(CancelOrderPayload payload);
        Task<PorfolioListResponse> GetPortfolioList(PortfolioListPayload payload);
        Task<PortfolioOpenOrdersResponse> GetPortfolioOpenOrderList(PortfolioOpenOrdersPayload payload);
        Task<GetPortfolioHistoryListResponse> GetPortfolioHistoryList(PortfolioHistoryListPayload payload);
        Task<CreatePortfolioOrderResponse> CreatePortfolioOrder(CreatePortfolioOrderPayload payload);
        Task<ClosePortfolioPositionResponse> ClosePortfolioPosition(ClosePortfolioPositionPayload payload);
        Task<GetUserInfoResponse> GetUserInfo();
    }
}
