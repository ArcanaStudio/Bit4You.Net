using System;
using Net.Arcanastudio.Bit4You.Model.Request.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Request.Orders
{
    public class CancelOrderRequest : SimulableRequestBase
    {
        public string TransactionId { get; }

        public CancelOrderRequest(string transactionId, bool isSimulation = false) : base(isSimulation)
        {
            TransactionId = transactionId ?? throw  new ArgumentNullException(nameof(transactionId));
        }
    }
}