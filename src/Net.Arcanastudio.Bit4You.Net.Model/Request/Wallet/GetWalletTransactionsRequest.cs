using System;
using Net.Arcanastudio.Bit4You.Model.Request.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Request.Wallet
{
    public class GetWalletTransactionsRequest : SimulableRequestBase
    {
        public string Iso { get; }

        public GetWalletTransactionsRequest(bool isSimulation = false, string iso = null) : base(isSimulation)
        {
            Iso = iso ?? throw new ArgumentNullException(nameof(iso));
        }
    }
}
