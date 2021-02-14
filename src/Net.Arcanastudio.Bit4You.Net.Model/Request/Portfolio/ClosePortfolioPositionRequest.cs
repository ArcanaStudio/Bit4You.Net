using System;
using Net.Arcanastudio.Bit4You.Model.Request.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Request.Portfolio
{
    public class ClosePortfolioPositionRequest : SimulableRequestBase
    {
        public string OrderId { get; set; }

        public ClosePortfolioPositionRequest(string orderId, bool isSimulation = false) : base(isSimulation)
        {
            OrderId = orderId ?? throw new ArgumentNullException(nameof(orderId));
        }
    }
}
