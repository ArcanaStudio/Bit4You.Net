using System.Collections.Generic;

namespace Net.Arcanastudio.Bit4You.Response
{
    internal abstract class BaseListResponse<T>
    {
        public List<T> Items { get; }

        protected BaseListResponse(List<T> items)
        {
            Items = items;
        }
    }
}
