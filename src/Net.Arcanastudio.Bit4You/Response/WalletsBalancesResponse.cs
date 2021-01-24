using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class WalletsBalancesResponse
    {
        [JsonPropertyName("iso")]
        public string Iso { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("tx_explorer")]
        public string Tx_explorer { get; set; }
        [JsonPropertyName("tx")]
        public string Tx { get; set; }
        [JsonPropertyName("erc20")]
        public string Erc20 { get; set; }
        [JsonPropertyName("balance")]
        public int Balance { get; set; }
        [JsonPropertyName("Adress")]
        public string Adress { get; set; }
    }
}
