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
