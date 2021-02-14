using System;
using Net.Arcanastudio.Bit4You.Model.Request.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Request.Orders
{
    public class GetOrdersListRequest : SimulableRequestBase
    {
        private readonly int _maxNumberOfLimit = 100;

        public int Page { get; }
        public int Limit { get; }
        public string Market { get; }

        public GetOrdersListRequest(bool isSimulation = false, int page = default, int limit = 10,
            string market = null) : base(isSimulation)
        {
            Page = page;
            if (limit > _maxNumberOfLimit)
                throw new ArgumentOutOfRangeException(nameof(limit));

            Limit = limit;
            Market = market ?? throw new ArgumentNullException(nameof(market));
        }
    }
}
