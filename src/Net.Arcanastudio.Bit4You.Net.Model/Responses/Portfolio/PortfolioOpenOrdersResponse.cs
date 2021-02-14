using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Portfolio
{
    public class PortfolioOpenOrdersResponse : BaseListResponse<PortfolioOpenOrderItem>
    {
        public PortfolioOpenOrdersResponse(List<PortfolioOpenOrderItem> items) : base(items)
        {
        }
    }

    public class PortfolioOpenOrderItem
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public float ExecuteAt { get; set; }
        public float RemainingQuantity { get; set; }
        public string RemainingIso { get; set; }
        public int IsOpening { get; set; }
        public string Market { get; set; }
        public string BaseCurrency { get; set; }
        public float Invested { get; set; }
        public int Quantity { get; set; }
        public int OpenTime { get; set; }

        public object CloseTime { get; set; }
    }

}
