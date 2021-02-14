using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Portfolio
{
    public class GetPortfolioHistoryListResponse : BaseListResponse<PortfolioHistoryResponseItem>
    {
        public GetPortfolioHistoryListResponse(List<PortfolioHistoryResponseItem> items) : base(items)
        {
        }
    }

    public class PortfolioHistoryResponseItem
    {
        public int Id { get; set; }
        public string Market { get; set; }
        public string BaseCurrency { get; set; }
        public float Invested { get; set; }
        public float ClosedAmount { get; set; }
        public float Quantity { get; set; }
        public int Fee { get; set; }
        public int OpenTime { get; set; }
        public int CloseTime { get; set; }
    }

}
