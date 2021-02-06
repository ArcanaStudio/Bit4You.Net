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

        [TestMethod, TestCategory("Token")]
        [JsonDataSource(FilePath = "TestData\\Token\\GetToken_OK.json")]
        public async Task GetToken_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<TokenResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<TokenResponse>(new FakeHttpMessageHandler<TokenResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetToken(new TokenPayload());

            response.Token.Should().Be(fakemessage.Content.Token);
        }


        #endregion


        #region UserInfo

        [TestMethod, TestCategory("UserInfo")]
        [JsonDataSource(FilePath = "TestData\\UserInfo\\GetUserInfo_OK.json")]
        public async Task GetUserInfo_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        [TestMethod, TestCategory("UserInfo")]
        [JsonDataSource(FilePath = "TestData\\Generic\\GenericAccessDenied.json")]
        public async Task GetUserInfo_AccessDenied(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        [TestMethod, TestCategory("UserInfo")]
        [JsonDataSource(FilePath = "TestData\\Generic\\GenericError.json")]
        public async Task GetUserInfo_Error(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        [TestMethod, TestCategory("UserInfo")]
        [JsonDataSource(FilePath = "TestData\\Generic\\GenericReconnect.json")]
        public async Task GetUserInfo_Reconnect(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetUserInfoResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetUserInfoResponse>(new FakeHttpMessageHandler<GetUserInfoResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetUserInfo();

            response.IdNumber.Should().Be(fakemessage.Content.IdNumber);
        }

        #endregion

        #region Wallet

        [TestMethod, TestCategory("Wallet")]
        [JsonDataSource(FilePath = "TestData\\Wallet\\GetWalletTransactions_OK.json")]
        public async Task GetWalletTransactions_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<WalletTransactions>();

            var fakehttpclientfactory = new FakeHttpClientFactory<WalletTransactions>(new FakeHttpMessageHandler<WalletTransactions>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetWalletTransactions(new WalletTransactionsPayload());

            response.Transactions.Length.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Wallet")]
        [JsonDataSource(FilePath = "TestData\\Wallet\\GetWalletBalances_OK.json")]
        public async Task GetWalletBalances_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<WalletsBalanceItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<WalletsBalanceItem>>(new FakeHttpMessageHandler<List<WalletsBalanceItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetWalletsBalance(new WalletsBalancesPayload());

            //response.Items.Count.Should().Be(fakemessage.Content.Count);//todo:change
        }

        #endregion

        #region Orders

        [TestMethod, TestCategory("Orders")]
        [JsonDataSource(FilePath = "TestData\\Orders\\CancelOrder_OK.json")]
        public async Task CancelOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<PortfolioCancelOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<PortfolioCancelOrderResponse>(new FakeHttpMessageHandler<PortfolioCancelOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CancelOrder(new CancelOrderPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Orders")]
        [JsonDataSource(FilePath = "TestData\\Orders\\CreateNewOrder_OK.json")]
        public async Task CreateNewOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<OrderItem>();

            var fakehttpclientfactory = new FakeHttpClientFactory<OrderItem>(new FakeHttpMessageHandler<OrderItem>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CreateOrder(new CreateOrderPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Orders")]
        [JsonDataSource(FilePath = "TestData\\Orders\\GetOrderInfo_OK.json")]
        public async Task GetOrderInfo_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<OrderItem>();

            var fakehttpclientfactory = new FakeHttpClientFactory<OrderItem>(new FakeHttpMessageHandler<OrderItem>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetOrderInfo(new OrderInfoPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Orders")]
        [JsonDataSource(FilePath = "TestData\\Orders\\GetOrders_OK.json")]
        public async Task GetOrders_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<OrderItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<OrderItem>>(new FakeHttpMessageHandler<List<OrderItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetOrdersList(new OrdersListPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Orders")]
        [JsonDataSource(FilePath = "TestData\\Orders\\GetPendingOrders_OK.json")]
        public async Task GetPendingOrders_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<OrdersPendingItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<OrdersPendingItem>>(new FakeHttpMessageHandler<List<OrdersPendingItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetOrdersPending(new OrderInfoPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        #endregion

        #region Portfolio

        [TestMethod, TestCategory("Portfolio")]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\CancelPortfolioOrder_OK.json")]
        public async Task CancelPortfolioOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<CancelOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<CancelOrderResponse>(new FakeHttpMessageHandler<CancelOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CancelOrder(new CancelOrderPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Portfolio")]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\ClosePortfolioPosition_OK.json")]
        public async Task ClosePortfolioPosition_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<ClosePortfolioOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<ClosePortfolioOrderResponse>(new FakeHttpMessageHandler<ClosePortfolioOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.ClosePortfolioOrder(new ClosePortfolioOrderPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Portfolio")]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\CreatePortfolioOrder_OK.json")]
        public async Task CreatePortfolioOrder_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<CreatePortfolioOrderResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<CreatePortfolioOrderResponse>(new FakeHttpMessageHandler<CreatePortfolioOrderResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.CreatePortfolioOrder(new CreatePortfolioOrderPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Portfolio")]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\GetPortfolioHistory_OK.json")]
        public async Task GetPortfolioHistory_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<PortfolioHistoryResponseItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<PortfolioHistoryResponseItem>>(new FakeHttpMessageHandler<List<PortfolioHistoryResponseItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketHistory(new MarketHistoryPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Portfolio")]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\GetPortfolioList_OK.json")]
        public async Task GetPortfolioList_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<PorfolioListResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<PorfolioListResponse>(new FakeHttpMessageHandler<PorfolioListResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetPortfolioList(new PortfolioListPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Portfolio")]
        [JsonDataSource(FilePath = "TestData\\Portfolio\\GetPortfolioOpenOrders_OK.json")]
        public async Task GetPortfolioOpenOrders_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<PortfolioOpenOrderItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<PortfolioOpenOrderItem>>(new FakeHttpMessageHandler<List<PortfolioOpenOrderItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetPortfolioOpenOrderList(new PortfolioOpenOrdersPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        #endregion

        #region Market

        [TestMethod, TestCategory("Market")]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketHistory_OK.json")]
        public async Task GetMarketHistory_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<MarketHistoryResponseItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<MarketHistoryResponseItem>>(new FakeHttpMessageHandler<List<MarketHistoryResponseItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketHistory(new MarketHistoryPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Market")]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketList_OK.json")]
        public async Task GetMarketList_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<MarketResponseItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<MarketResponseItem>>(new FakeHttpMessageHandler<List<MarketResponseItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketList();

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Market")]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketOrderBook_OK.json")]
        public async Task GetMarketOrderBook_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetMarketOrderbookResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetMarketOrderbookResponse>(new FakeHttpMessageHandler<GetMarketOrderbookResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketOrderBook(new GetMarketOrderbookPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Market")]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketOrderBookWithStatus_OK.json")]
        public async Task GetMarketOrderBookWithStatus_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<GetMarketOrderbookResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<GetMarketOrderbookResponse>(new FakeHttpMessageHandler<GetMarketOrderbookResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketOrderBook(new GetMarketOrderbookPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Market")]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketSummaries_OK.json")]
        public async Task GetMarketSummaries_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<MarketSummaryItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<MarketSummaryItem>>(new FakeHttpMessageHandler<List<MarketSummaryItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketSummaries();

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        [TestMethod, TestCategory("Market")]
        [JsonDataSource(FilePath = "TestData\\Market\\GetMarketTick_OK.json")]
        public async Task GetMarketTick_OK(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<List<MarketTickItem>>();

            var fakehttpclientfactory = new FakeHttpClientFactory<List<MarketTickItem>>(new FakeHttpMessageHandler<List<MarketTickItem>>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetMarketTicks(new MarketTicksPayload());

            //response.Data.Count.Should().Be(fakemessage.Content.Transactions.Length);//todo:change
        }

        #endregion

    }
}
