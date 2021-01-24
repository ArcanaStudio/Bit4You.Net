using System.Threading.Tasks;
using Bit4You.Net.Payload;
using Bit4You.Net.Response;
using Bit4You.Net.Service;
using Bit4You.Service.Tests.Helpers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bit4You.Service.Tests
{
    [TestClass]
    public class Bit4YouServiceTest
    {
        [TestMethod]
        [JsonDataSource(FilePath = "TestData\\Token_Succeed.json")]
        public async Task Test1(string jsondatasource)
        {
            var fakemessage = jsondatasource.ToFakeMessage<TokenResponse>();

            var fakehttpclientfactory = new FakeHttpClientFactory<TokenResponse>(new FakeHttpMessageHandler<TokenResponse>(fakemessage));

            var sut = new Bit4YouService(fakehttpclientfactory);

            var response = await sut.GetToken(new TokenPayload());

            response.IsError.Should().BeFalse();
            response.Data.Should().NotBeNull();
            response.Data.Token.Should().Be(fakemessage.Content.Token);
        }
    }
}
