using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Response.Generic;

namespace Net.Arcanastudio.Bit4You.Response.Orders
{
    internal class GetOrdersPendingResponse : BaseListResponse<OrdersPendingItem>
    {
        public GetOrdersPendingResponse(List<OrdersPendingItem> items) : base(items)
        {
        }
    }

    internal class OrdersPendingItem : OrderItem
    {

    }
}
