using System;

namespace Net.Arcanastudio.Bit4You.Model.Responses.Orders
{
    public class CancelOrderResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string TransactionId { get; set; }
        public string BuyIso { get; set; }
        public int BuyQuantity { get; set; }
        public int BuyFee { get; set; }
        public string SellIso { get; set; }
        public int SellQuantity { get; set; }
        public int SellFee { get; set; }
        public string BaseType { get; set; }
        public float BaseRate { get; set; }
        public int RemainingQuantity { get; set; }
        public string RemainingIso { get; set; }
        public int BlockedQuantity { get; set; }
        public bool IsOpen { get; set; }
        public string Ip { get; set; }
        public object PortfolioId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}