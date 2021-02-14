namespace Net.Arcanastudio.Bit4You.Model.Responses.Wallet
{
    internal class WalletsBalancesResponse
    {
        public string Iso { get; set; }
        public string Name { get; set; }
        public bool Tx_Enabled{ get; set; }
        public string Tx_explorer { get; set; }
        public string Tx { get; set; }
        public bool Erc20 { get; set; }
        public float Balance { get; set; }
        public int Digits { get; set; }
    }
}