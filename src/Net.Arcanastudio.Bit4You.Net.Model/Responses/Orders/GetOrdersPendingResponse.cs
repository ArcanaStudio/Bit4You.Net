using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Model.Responses.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Orders
{
    public class GetOrdersPendingResponse : BaseListResponse<OrdersPendingItem>
    {
        public GetOrdersPendingResponse(List<OrdersPendingItem> items) : base(items)
        {
        }
    }

    public class OrdersPendingItem : OrderItem
    {

    }
}
