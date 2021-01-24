using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Net.Arcanastudio.Bit4You.Extensions;
using Net.Arcanastudio.Bit4You.Payload;
using Net.Arcanastudio.Bit4You.Response;

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

        public async Task<ServiceResponse<TokenResponse>> GetToken(TokenPayload payload)
        {
            var response = await SendPostRequest<TokenResponse>(Constants.Apis.GetToken, payload).ConfigureAwait(false);
            if (!response.IsError)
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", response.Data.Token);

            return response;
        }

        public async Task<ServiceResponse<GetUserInfoResponse>> GetUserInfo()
        {
            return await SendGetRequest<GetUserInfoResponse>(Constants.Apis.GetUserInfo).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<MarketResponse>>> GetMarketList()
        {
            return await SendGetRequest<List<MarketResponse>>(Constants.Apis.GetMarketList).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<MarketSummaryResponse>>> GetMarketSummaries()
        {
            return await SendGetRequest<List<MarketSummaryResponse>>(Constants.Apis.GetMarketSummaries).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<MarketSummaryResponse>>> GetMarketTicks(MarketTicksPayload payload)
        {
            return await SendPostRequest<List<MarketSummaryResponse>>(Constants.Apis.GetMarketTicks, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<MarketSummaryResponse>>> GetMarketOrderBook(MarketOrderbookPayload payload)
        {
            return await SendPostRequest<List<MarketSummaryResponse>>(Constants.Apis.GetMarketOrderbooks, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<MarketHistoryResponse>>> GetMarketHistory(MarketHistoryPayload payload)
        {
            return await SendPostRequest<List<MarketHistoryResponse>>(Constants.Apis.GetMarketHistory, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<WalletsBalancesResponse>>> GetWalletsBalance(WalletsBalancesPayload payload)
        {
            return await SendPostRequest<List<WalletsBalancesResponse>>(Constants.Apis.GetWalletsBalance, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<WalletTransactionsResponse>>> GetWalletTransactions(WalletTransactionsPayload payload)
        {
            return await SendPostRequest<List<WalletTransactionsResponse>>(Constants.Apis.GetWalletTransactions, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<WalletTransactionsResponse>>> WalletWithdrawFunds(WalletWithdrawFundsPayload payload)
        {
            return await SendPostRequest<List<WalletTransactionsResponse>>(Constants.Apis.WalletWithdrawFunds, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<OrderInfoResponse>>> GetOrdersList(OrdersListPayload payload)
        {
            return await SendPostRequest<List<OrderInfoResponse>>(Constants.Apis.GetOrdersList, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<OrderInfoResponse>> GetOrderInfo(OrderInfoPayload payload)
        {
            return await SendPostRequest<OrderInfoResponse>(Constants.Apis.GetOrderInfo, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<List<OrderInfoResponse>>> GetOrdersPending(OrderInfoPayload payload)
        {
            return await SendPostRequest<List<OrderInfoResponse>>(Constants.Apis.GetOrderPendingsList, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<OrderInfoResponse>> CreateOrder(CreateOrderPayload payload)
        {
            return await SendPostRequest<OrderInfoResponse>(Constants.Apis.CreateOrder, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<CancelOrderResponse>> CancelOrder(CancelOrderPayload payload)
        {
            return await SendPostRequest<CancelOrderResponse>(Constants.Apis.CancelOrder, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<PorfolioListResponse>> GetPortfolioList(PortfolioListPayload payload)
        {
            return await SendPostRequest<PorfolioListResponse>(Constants.Apis.GetPortfolioList, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<PortfolioOpenOrdersResponse>> GetPortfolioOpenOrderList(PortfolioOpenOrdersPayload payload)
        {
            return await SendPostRequest<PortfolioOpenOrdersResponse>(Constants.Apis.GetPortfolioOpenOrderList, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<GetPortfolioHistoryListResponse>> GetPortfolioHistoryList(PortfolioHistoryListPayload payload)
        {
            return await SendPostRequest<GetPortfolioHistoryListResponse>(Constants.Apis.GetPortfolioHistoryList, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<CreatePortfolioOrderResponse>> CreatePortfolioOrder(CreatePortfolioOrderPayload payload)
        {
            return await SendPostRequest<CreatePortfolioOrderResponse>(Constants.Apis.CreatePortfolioOrder, payload).ConfigureAwait(false);
        }

        public async Task<ServiceResponse<ClosePortfolioOrderResponse>> ClosePortfolioOrder(ClosePortfolioOrderPayload payload)
        {
            return await SendPostRequest<ClosePortfolioOrderResponse>(Constants.Apis.ClosePortfolioOrder, payload).ConfigureAwait(false);
        }

        private async Task<ServiceResponse<T>> SendGetRequest<T>(string url)
        {
            var response = await _httpClient.GetAsync(url).ConfigureAwait(false);

            return await TreatResponse<T>(response);
        }

        private async Task<ServiceResponse<T>> SendPostRequest<T>(string url, object payload)
        {
            var jsonpayload = payload.JsonSerialize();

            var response = await _httpClient.PostAsync(url, new StringContent(jsonpayload)).ConfigureAwait(false);

            return await TreatResponse<T>(response);
        }

        private async Task<ServiceResponse<T>> TreatResponse<T>(HttpResponseMessage responsemessage)
        {
            var requestresponse = new RequestResponse();

            var responsedata = await responsemessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            requestresponse.StatusCode = responsemessage.StatusCode;

            if (responsemessage.IsSuccessStatusCode)
                return new ServiceResponse<T>(responsedata.Deserialize<T>());
            
            var error = responsedata.Deserialize<RequestError>();
            return new ServiceResponse<T>(error?.Error ?? string.Empty);
        }

        private class RequestError
        {
            [JsonPropertyName("error")]
            public string Error { get; set; }
            [JsonPropertyName("reconnect")]
            public bool Reconnect { get; set; }
        }
    }
}
