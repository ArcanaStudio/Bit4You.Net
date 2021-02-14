using System.Collections.Generic;
using Net.Arcanastudio.Bit4You.Response.Generic;

namespace Net.Arcanastudio.Bit4You.Response.Orders
{
    internal class GetOrdersListResponse : BaseListResponse<OrderItem>
    {
        public GetOrdersListResponse(List<OrderItem> items) : base(items)
        {
        }
    }
}
