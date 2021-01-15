using System.Text.Json.Serialization;

namespace Bit4You.Net.Payload
{
    internal class WalletWithdrawFundsPayload
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}
