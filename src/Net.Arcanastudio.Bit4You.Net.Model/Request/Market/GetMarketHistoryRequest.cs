using System;

namespace Net.Arcanastudio.Bit4You.Model.Request.Market
{
    public class GetMarketHistoryRequest
    {
        public string Market { get; }
        public int Limit { get; }
        public string From { get; }
        public string To { get; }

        public GetMarketHistoryRequest(string market, int limit = 20, string from = null, string to = null)
        {
            Market = market ?? throw new ArgumentNullException(nameof(market));
            Limit = limit;
            From = from;
            To = to;
        }
    }
}
