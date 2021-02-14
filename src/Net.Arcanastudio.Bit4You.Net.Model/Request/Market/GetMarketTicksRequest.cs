using System;

namespace Net.Arcanastudio.Bit4You.Model.Request.Market
{
    public class GetMarketTicksRequest
    {
        public string Market { get; }
        public MarketTick Interval { get; }

        public GetMarketTicksRequest(string market, MarketTick interval)
        {
            Market = market ?? throw new ArgumentNullException(nameof(market));
            if (!Enum.IsDefined(typeof(MarketTick), interval))
                throw new ArgumentOutOfRangeException(nameof(interval));
            Interval = interval;
        }

        public enum MarketTick
        {
            OneMinute = 60,
            FiveMinutes = 300,
            Quarter = 900,
            HalfHour = 1800,
            OneHour = 3600,
            FourHours = 14400,
            HalfDay = 43200,
            Day = 86400
        }
    }
}
