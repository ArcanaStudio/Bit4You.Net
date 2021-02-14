using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Market
{
    public class GetMarketListResponse : BaseListResponse<MarketResponseItem>
    {
        public GetMarketListResponse(List<MarketResponseItem> items) : base(items)
        {
        }
    }

    public class MarketResponseItem
    {
        public string Iso { get; set; }
        public string Name { get; set; }
        public int Precision { get; set; }
        public float Value { get; set; }
        public float Change { get; set; }
        public float Spread { get; set; }
        public string Category { get; set; }
    }
}
