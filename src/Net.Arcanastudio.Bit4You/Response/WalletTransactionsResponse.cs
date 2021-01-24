using System.Text.Json.Serialization;

namespace Bit4You.Net.Response
{
    internal class WalletTransactionsResponse
    {
        [JsonPropertyName("balance")]
        public float Balance { get; set; }
        [JsonPropertyName("pages")]
        public int Pages { get; set; }
        [JsonPropertyName("txs")]
        public TransactionResponse[] Transactions { get; set; }
    }

    internal class TransactionResponse
    {
        [JsonPropertyName("txid")]
        public string Id { get; set; }
        [JsonPropertyName("block")]
        public object Block { get; set; }
        [JsonPropertyName("confirmations")]
        public object Confirmations { get; set; }
        [JsonPropertyName("fee")]
        public int Fee { get; set; }
        [JsonPropertyName("time")]
        public int Time { get; set; }
        [JsonPropertyName("quantity")]
        public float Quantity { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("meta")]
        public TransactionMetaResponse Meta { get; set; }
    }

    internal class TransactionMetaResponse
    {
        [JsonPropertyName("pending")]
        public bool Pending { get; set; }
        [JsonPropertyName("paid_value")]
        public float PaidValue { get; set; }
        [JsonPropertyName("paid_asset")]
        public string PaidAsset { get; set; }
        [JsonPropertyName("fee_asset")]
        public string FeeQsset { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
    }

}
