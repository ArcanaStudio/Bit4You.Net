using System;

namespace Net.Arcanastudio.Bit4You.Model.Request.Wallet
{
    public class WithdrawWalletFundsPayload
    {
        public string Iso { get; set; }
        public float Quantity { get; set; }
        public string Address { get; set; }

        public WithdrawWalletFundsPayload(string iso, float quantity, string address)
        {
            Iso = iso ?? throw new ArgumentNullException(nameof(iso));
            if (quantity < 0)
                throw new ArgumentOutOfRangeException(nameof(quantity));
            Quantity = quantity;
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
