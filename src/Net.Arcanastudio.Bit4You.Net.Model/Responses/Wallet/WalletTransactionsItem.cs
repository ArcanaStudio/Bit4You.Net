namespace Net.Arcanastudio.Bit4You.Model.Responses.Wallet
{
    internal class WalletTransactions
    {
        public float Balance { get; set; }
        public int Pages { get; set; }
        public Transaction[] Transactions { get; set; }
    }

    internal class Transaction
    {
        public string Id { get; set; }
        public object Block { get; set; }
        public object Confirmations { get; set; }
        public int Fee { get; set; }
        public int Time { get; set; }
        public float Quantity { get; set; }
        public string Type { get; set; }
        public TransactionMeta Meta { get; set; }
    }

    internal class TransactionMeta
    {
        public bool Pending { get; set; }
        public float PaidValue { get; set; }
        public string PaidAsset { get; set; }
        public string FeeQsset { get; set; }
        public string Market { get; set; }
    }

}
