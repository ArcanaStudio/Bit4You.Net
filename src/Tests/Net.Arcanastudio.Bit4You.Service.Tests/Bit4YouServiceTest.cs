using System.Collections.Generic;
using System.Threading.Tasks;
using Arcana.Toolkit.Testing.MsTest;
using Arcana.Toolkit.Testing.MsTest.Attributes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.Arcanastudio.Bit4You.Payload;
using Net.Arcanastudio.Bit4You.Response;
using Net.Arcanastudio.Bit4You.Service;
using Net.Arcanastudio.Bit4You.Tests.Helpers;

namespace Net.Arcanastudio.Bit4You.Tests
{
    [TestClass]
    public class Bit4YouServiceTest
    {
        #region Token

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Token\\GetToken_OK.json")]
        public async Task GetToken_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<TokenResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<TokenResponse>(new FakeHttpMessageHandler<TokenResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetToken(new TokenPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.Token.Should().Be(fakemessage.Content.Token);
        }


        #endregion


        #region UserInfo

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\UserInfo\\GetUserInfo_OK.json")]
        public async Task GetUserInfo_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Generic\\GenericAccessDenied.json")]
        public async Task GetUserInfo_AccessDenied(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Generic\\GenericError.json")]
        public async Task GetUserInfo_Error(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Generic\\GenericReconnect.json")]
        public async Task GetUserInfo_Reconnect(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        #endregion

        #region Wallet

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Wallet\\GetWalletTransactions_OK.json")]
        public async Task GetWalletTransactions_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<WalletTransactionsResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<WalletTransactionsResponse>(new FakeHttpMessageHandler<WalletTransactionsResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetWalletTransactions(new WalletTransactionsPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Wallet\\GetWalletBalances_OK.json")]
        public async Task GetWalletBalances_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<WalletsBalancesResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<WalletsBalancesResponse>(new FakeHttpMessageHandler<WalletsBalancesResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetWalletsBalance(new WalletsBalancesPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.Count.Should().Be(fakemessage.Content.Balance);//todo:change
        }

        #endregion

        #region Orders

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Orders\\CancelOrder_OK.json")]
        public async Task CancelOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<PortfolioCancelOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<PortfolioCancelOrderResponse>(new FakeHttpMessageHandler<PortfolioCancelOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CancelOrder(new CancelOrderPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Orders\\CreateNewOrder_OK.json")]
        public async Task CreateNewOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<OrderInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<OrderInfoResponse>(new FakeHttpMessageHandler<OrderInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CreateOrder(new CreateOrderPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Orders\\GetOrderInfo_OK.json")]
        public async Task GetOrderInfo_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<OrderInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<OrderInfoResponse>(new FakeHttpMessageHandler<OrderInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetOrderInfo(new OrderInfoPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Orders\\GetOrders_OK.json")]
        public async Task GetOrders_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<OrderInfoResponse>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<OrderInfoResponse>>(new FakeHttpMessageHandler<List<OrderInfoResponse>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetOrdersList(new OrdersListPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Orders\\GetPendingOrders_OK.json")]
        public async Task GetPendingOrders_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<OrderInfoResponse>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<OrderInfoResponse>>(new FakeHttpMessageHandler<List<OrderInfoResponse>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetOrdersPending(new OrderInfoPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        #endregion

        #region Portfolio

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\CancelPortfolioOrder_OK.json")]
        public async Task CancelPortfolioOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<CancelOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<CancelOrderResponse>(new FakeHttpMessageHandler<CancelOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CancelOrder(new CancelOrderPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\ClosePortfolioPosition_OK.json")]
        public async Task ClosePortfolioPosition_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<ClosePortfolioOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<ClosePortfolioOrderResponse>(new FakeHttpMessageHandler<ClosePortfolioOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.ClosePortfolioOrder(new ClosePortfolioOrderPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\CreatePortfolioOrder_OK.json")]
        public async Task CreatePortfolioOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<CreatePortfolioOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<CreatePortfolioOrderResponse>(new FakeHttpMessageHandler<CreatePortfolioOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CreatePortfolioOrder(new CreatePortfolioOrderPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\GetPortfolioHistory_OK.json")]
        public async Task GetPortfolioHistory_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetPortfolioHistoryListResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetPortfolioHistoryListResponse>(new FakeHttpMessageHandler<GetPortfolioHistoryListResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketHistory(new MarketHistoryPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\GetPortfolioList_OK.json")]
        public async Task GetPortfolioList_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<PorfolioListResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<PorfolioListResponse>(new FakeHttpMessageHandler<PorfolioListResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetPortfolioList(new PortfolioListPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\GetPortfolioOpenOrders_OK.json")]
        public async Task GetPortfolioOpenOrders_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<PortfolioOpenOrdersResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<PortfolioOpenOrdersResponse>(new FakeHttpMessageHandler<PortfolioOpenOrdersResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetPortfolioOpenOrderList(new PortfolioOpenOrdersPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        #endregion

        #region Market

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketHistory_OK.json")]
        public async Task GetMarketHistory_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<MarketHistoryResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<MarketHistoryResponse>(new FakeHttpMessageHandler<MarketHistoryResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketHistory(new MarketHistoryPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketList_OK.json")]
        public async Task GetMarketList_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<MarketResponse>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<MarketResponse>>(new FakeHttpMessageHandler<List<MarketResponse>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketList();

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketOrderBook_OK.json")]
        public async Task GetMarketOrderBook_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<MarketOrderbookResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<MarketOrderbookResponse>(new FakeHttpMessageHandler<MarketOrderbookResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketOrderBook(new MarketOrderbookPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketSummaries_OK.json")]
        public async Task GetMarketSummaries_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<MarketSummaryResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<MarketSummaryResponse>(new FakeHttpMessageHandler<MarketSummaryResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketSummaries();

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketTick_OK.json")]
        public async Task GetMarketTick_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<MarketTicksResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<MarketTicksResponse>(new FakeHttpMessageHandler<MarketTicksResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketTicks(new MarketTicksPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        #endregion

    }
}
