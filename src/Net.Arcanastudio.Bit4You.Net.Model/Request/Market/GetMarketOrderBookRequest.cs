using System;

namespace Net.Arcanastudio.Bit4You.Model.Request.Market
{
    public class GetMarketOrderBookRequest
    {
        public string Market { get; }
        public int Limit { get;  }
        public bool State { get; }

        public GetMarketOrderBookRequest(string market, int limit = 10, bool state = false)
        {
            Market = market ?? throw new ArgumentNullException(nameof(market));
            Limit = limit;
            State = state;
        }
    }
}
