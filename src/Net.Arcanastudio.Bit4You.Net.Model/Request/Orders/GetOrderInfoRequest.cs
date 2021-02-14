using System;
using Net.Arcanastudio.Bit4You.Model.Request.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Request.Orders
{
    public class GetOrderInfoRequest : SimulableRequestBase
    {
        public string TransactionId { get; }

        public GetOrderInfoRequest(string transactionId, bool isSimulation = false) : base(isSimulation)
        {
            TransactionId = transactionId ?? throw new ArgumentNullException(nameof(transactionId));
        }
    }
}
