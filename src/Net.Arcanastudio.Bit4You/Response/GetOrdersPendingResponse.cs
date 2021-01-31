using System;
using System.Collections.Generic;
using System.Text;

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
