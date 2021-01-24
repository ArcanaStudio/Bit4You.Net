using System.Collections.Generic;
using System.Threading.Tasks;
using Net.Arcanastudio.Bit4You.Payload;
using Net.Arcanastudio.Bit4You.Response;

namespace Net.Arcanastudio.Bit4You.Service
{
    internal interface IBit4YouService
    {
        Task<ServiceResponse<TokenResponse>> GetToken(TokenPayload payload);
        Task<ServiceResponse<List<MarketResponse>>> GetMarketList();
        Task<ServiceResponse<List<MarketSummaryResponse>>> GetMarketSummaries();
        Task<ServiceResponse<List<MarketSummaryResponse>>> GetMarketTicks(MarketTicksPayload payload);
        Task<ServiceResponse<List<MarketSummaryResponse>>> GetMarketOrderBook(MarketOrderbookPayload payload);
        Task<ServiceResponse<List<MarketHistoryResponse>>> GetMarketHistory(MarketHistoryPayload payload);
        Task<ServiceResponse<List<WalletsBalancesResponse>>> GetWalletsBalance(WalletsBalancesPayload payload);
        Task<ServiceResponse<List<WalletTransactionsResponse>>> GetWalletTransactions(WalletTransactionsPayload payload);
        Task<ServiceResponse<List<WalletTransactionsResponse>>> WalletWithdrawFunds(WalletWithdrawFundsPayload payload);
        Task<ServiceResponse<List<OrderInfoResponse>>> GetOrdersList(OrdersListPayload payload);
        Task<ServiceResponse<OrderInfoResponse>> GetOrderInfo(OrderInfoPayload payload);
        Task<ServiceResponse<List<OrderInfoResponse>>> GetOrdersPending(OrderInfoPayload payload);
        Task<ServiceResponse<OrderInfoResponse>> CreateOrder(CreateOrderPayload payload);
        Task<ServiceResponse<CancelOrderResponse>> CancelOrder(CancelOrderPayload payload);
        Task<ServiceResponse<PorfolioListResponse>> GetPortfolioList(PortfolioListPayload payload);
        Task<ServiceResponse<PortfolioOpenOrdersResponse>> GetPortfolioOpenOrderList(PortfolioOpenOrdersPayload payload);
        Task<ServiceResponse<GetPortfolioHistoryListResponse>> GetPortfolioHistoryList(PortfolioHistoryListPayload payload);
        Task<ServiceResponse<CreatePortfolioOrderResponse>> CreatePortfolioOrder(CreatePortfolioOrderPayload payload);
        Task<ServiceResponse<ClosePortfolioOrderResponse>> ClosePortfolioOrder(ClosePortfolioOrderPayload payload);
        Task<ServiceResponse<GetUserInfoResponse>> GetUserInfo();
    }
}
