using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class WalletTransactions
    {
        [JsonPropertyName("balance")]
        public float Balance { get; set; }
        [JsonPropertyName("pages")]
        public int Pages { get; set; }
        [JsonPropertyName("txs")]
        public Transaction[] Transactions { get; set; }
    }

    internal class Transaction
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
        public TransactionMeta Meta { get; set; }
    }

    internal class TransactionMeta
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
