using System.Collections.Generic;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal class GetOrdersListResponse : BaseListResponse<OrderItem>
    {
        public GetOrdersListResponse(List<OrderItem> items) : base(items)
        {
        }
    }
}
