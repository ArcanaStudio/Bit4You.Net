using System.Collections.Generic;

namespace Net.Arcanastudio.Bit4You.Response
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
