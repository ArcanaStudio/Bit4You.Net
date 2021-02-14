using System;
using Net.Arcanastudio.Bit4You.Model.Request.Generic;

namespace Net.Arcanastudio.Bit4You.Model.Request.Orders
{
    public class CreateOrderRequest : SimulableRequestBase
    {
        public string Market { get; set; }
        public OrderType Type { get; set; }
        public float Quantity { get; set; }
        public string QuantityIso { get; set; }
        public float Rate { get; set; }

        public CreateOrderRequest(string market, OrderType type, float quantity, float rate, string quantityIso = null, bool isSimulation = false) : base(isSimulation)
        {
            Market = market ?? throw new ArgumentNullException(nameof(market));
            if (!Enum.IsDefined(typeof(OrderType), type))
                throw new ArgumentOutOfRangeException(nameof(type));
            Type = type;
            Quantity = quantity;
            QuantityIso = quantityIso;
            Rate = rate;
        }

        public enum OrderType
        {
            Buy,
            Sell
        }
    }
}
