using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Net.Arcanastudio.Bit4You.Extensions;
using Net.Arcanastudio.Bit4You.Model.Exceptions;
using Net.Arcanastudio.Bit4You.Payload;
using Net.Arcanastudio.Bit4You.Response;
using Net.Arcanastudio.Bit4You.Response.Generic;
using Net.Arcanastudio.Bit4You.Response.GetUserInfo;
using Net.Arcanastudio.Bit4You.Response.Market;
using Net.Arcanastudio.Bit4You.Response.Orders;
using Net.Arcanastudio.Bit4You.Response.Portfolio;
using Net.Arcanastudio.Bit4You.Response.Token;

namespace Net.Arcanastudio.Bit4You.Service
{
    internal class Bit4YouService : IBit4YouService
    {
        private readonly HttpClient _httpClient;

        internal Bit4YouService(IHttpClientFactory httpservice = null)
        {
            if (httpservice == null)
                throw new ArgumentNullException(nameof(httpservice));

            _httpClient = httpservice.Create();
        }

        public async Task<TokenResponse> GetToken(TokenPayload payload)
        {
            var response = await SendPostRequest<TokenResponse>(Constants.Apis.GetToken, payload).ConfigureAwait(false);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", response.Token);

            return response;
        }

        public async Task<GetUserInfoResponse> GetUserInfo()
        {
            return await SendGetRequest<GetUserInfoResponse>(Constants.Apis.GetUserInfo).ConfigureAwait(false);
        }

        public async Task<GetMarketListResponse> GetMarketList()
        {
            var list = await SendGetRequest<List<MarketResponseItem>>(Constants.Apis.GetMarketList).ConfigureAwait(false);

            return new GetMarketListResponse(list);
        }

        public async Task<GetMarketSummariesResponse> GetMarketSummaries()
        {
            var list = await SendGetRequest<List<MarketHistoryResponseItem>>(Constants.Apis.GetMarketSummaries).ConfigureAwait(false);

            return new GetMarketSummariesResponse(list);
        }

        public async Task<GetMarketTicksResponse> GetMarketTicks(MarketTicksPayload payload)
        {
            var list = await SendPostRequest<List<MarketTickItem>>(Constants.Apis.GetMarketTicks, payload).ConfigureAwait(false);

            return new GetMarketTicksResponse(list);
        }

        public async Task<GetMarketOrderBookResponse> GetMarketOrderBook(GetMarketOrderBookPayload payload)
        {
            return await SendPostRequest<GetMarketOrderBookResponse>(Constants.Apis.GetMarketOrderbooks, payload).ConfigureAwait(false);
        }

        public async Task<GetMarketHistoryResponse> GetMarketHistory(MarketHistoryPayload payload)
        {
            var list = await SendPostRequest<List<MarketHistoryItem>>(Constants.Apis.GetMarketHistory, payload).ConfigureAwait(false);

            return new GetMarketHistoryResponse(list);
        }

        public async Task<GetWalletsBalanceResponse> GetWalletsBalance(WalletsBalancesPayload payload)
        {
            var list = await SendPostRequest<List<WalletsBalanceItem>>(Constants.Apis.GetWalletsBalance, payload).ConfigureAwait(false);

            return new GetWalletsBalanceResponse(list);
        }

        public async Task<GetWalletTransactionsResponse> GetWalletTransactions(WalletTransactionsPayload payload)
        {
           return await SendPostRequest<GetWalletTransactionsResponse>(Constants.Apis.GetWalletTransactions, payload).ConfigureAwait(false);
        }

        public async Task<WalletWithdrawFundsResponse> WalletWithdrawFunds(WalletWithdrawFundsPayload payload)
        {
            return await SendPostRequest<WalletWithdrawFundsResponse>(Constants.Apis.WalletWithdrawFunds, payload).ConfigureAwait(false);
        }

        public async Task<GetOrdersListResponse> GetOrdersList(OrdersListPayload payload)
        {
            var list = await SendPostRequest<List<OrderItem>>(Constants.Apis.GetOrdersList, payload).ConfigureAwait(false);

            return new GetOrdersListResponse(list);
        }

        public async Task<OrderItem> GetOrderInfo(OrderInfoPayload payload)
        {
            return await SendPostRequest<OrderItem>(Constants.Apis.GetOrderInfo, payload).ConfigureAwait(false);
        }

        public async Task<GetOrdersPendingResponse> GetOrdersPending(OrderInfoPayload payload)
        {
            var list = await SendPostRequest<List<OrdersPendingItem>>(Constants.Apis.GetOrderPendingsList, payload).ConfigureAwait(false);

            return new GetOrdersPendingResponse(list);
        }

        public async Task<OrderItem> CreateOrder(CreateOrderPayload payload)
        {
            return await SendPostRequest<OrderItem>(Constants.Apis.CreateOrder, payload).ConfigureAwait(false);
        }

        public async Task<CancelOrderResponse> CancelOrder(CancelOrderPayload payload)
        {
            return await SendPostRequest<CancelOrderResponse>(Constants.Apis.CancelOrder, payload).ConfigureAwait(false);
        }

        public async Task<PorfolioListResponse> GetPortfolioList(PortfolioListPayload payload)
        {
            return await SendPostRequest<PorfolioListResponse>(Constants.Apis.GetPortfolioList, payload).ConfigureAwait(false);
        }
  
        public async Task<PortfolioOpenOrdersResponse> GetPortfolioOpenOrderList(PortfolioOpenOrdersPayload payload)
        {
            var list = await SendPostRequest<List<PortfolioOpenOrderItem>>(Constants.Apis.GetPortfolioOpenOrderList, payload).ConfigureAwait(false);

            return new PortfolioOpenOrdersResponse(list);
    }

        public async Task<GetPortfolioHistoryListResponse> GetPortfolioHistoryList(PortfolioHistoryListPayload payload)
        {
            return await SendPostRequest<GetPortfolioHistoryListResponse>(Constants.Apis.GetPortfolioHistoryList, payload).ConfigureAwait(false);
        }

        public async Task<CreatePortfolioOrderResponse> CreatePortfolioOrder(CreatePortfolioOrderPayload payload)
        {
            return await SendPostRequest<CreatePortfolioOrderResponse>(Constants.Apis.CreatePortfolioOrder, payload).ConfigureAwait(false);
        }

        public async Task<ClosePortfolioPositionResponse> ClosePortfolioPosition(ClosePortfolioPositionPayload payload)
        {
            return await SendPostRequest<ClosePortfolioPositionResponse>(Constants.Apis.ClosePortfolioOrder, payload).ConfigureAwait(false);
        }

        private async Task<T> SendGetRequest<T>(string url)
        {
            var response = await _httpClient.GetAsync(url).ConfigureAwait(false);

            return await TreatResponse<T>(response);
        }

        private async Task<T> SendPostRequest<T>(string url, object payload)
        {
            var jsonpayload = payload.JsonSerialize();

            var response = await _httpClient.PostAsync(url, new StringContent(jsonpayload)).ConfigureAwait(false);

            return await TreatResponse<T>(response);
        }

        private async Task<T> TreatResponse<T>(HttpResponseMessage responsemessage)
        {
            var requestresponse = new RequestResponse();
            Bit4YouException exception;

            var responsedata = await responsemessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            requestresponse.StatusCode = responsemessage.StatusCode;

            if (responsemessage.IsSuccessStatusCode)
            {
                var response = responsedata.Deserialize<T>();
                // errors also returns 200 OK, so we try this hack
                if (!IsObjectDefault(response))
                    return response;
            }

            try
            {
                var error = responsedata.Deserialize<RequestError>();
                exception =  new Bit4YouException(responsemessage.StatusCode, error.ToErrorInfo());
            }
            catch 
            {
                exception = new Bit4YouException(responsemessage.StatusCode, new Bit4YouException.ErrorInfo{Message = responsedata, Status = "Unknown exception"});
            }

            throw exception;
        }

        private bool IsObjectDefault(object o)
        {
            var secondinstance = Activator.CreateInstance(o.GetType());

            var props = o.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(d => d.CanRead);


            var isdefault = props.All(d => (d.GetValue(o) == null || d.GetValue(o).Equals(d.GetValue(secondinstance))));

            return isdefault;
        }

        internal class RequestError
        {
            [JsonPropertyName("status")]
            public string Status { get; set; }
            [JsonPropertyName("message")]
            public string Message { get; set; }
            [JsonPropertyName("reconnect")]
            public bool? Reconnect { get; set; }
        }
    }
}
