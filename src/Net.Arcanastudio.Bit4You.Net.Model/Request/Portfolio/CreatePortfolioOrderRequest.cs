using System;
using Net.Arcanastudio.Bit4You.Model.Request.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Request.Portfolio
{
    public class CreatePortfolioOrderRequest : SimulableRequestBase
    {
        public string Market { get; }
        public float Amount { get; }
        public float? Rate { get; }

        public CreatePortfolioOrderRequest(bool isSimulation = false, string market = null, float amount = default,
            float? rate = null) : base(isSimulation)
        {
            Market = market ?? throw new ArgumentNullException(nameof(market));
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));
            Amount = amount;
            if (rate < 0)
                throw new ArgumentNullException(nameof(rate));
            Rate = rate;
        }
    }
}
