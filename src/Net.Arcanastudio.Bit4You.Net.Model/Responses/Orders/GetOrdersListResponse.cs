using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Orders
{
    public class GetOrdersListResponse : BaseListResponse<OrderItem>
    {
        public GetOrdersListResponse(List<OrderItem> items) : base(items)
        {
        }
    }
}
