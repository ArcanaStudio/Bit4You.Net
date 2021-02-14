using System;
using System.Text.Json.Serialization;

namespace Net.Arcanastudio.Bit4You.Response.Portfolio
{
    internal class CreatePortfolioOrderResponse
    {
        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("buy_quantity")]
        public int BuyQuantity { get; set; }
        [JsonPropertyName("buy_fee")]
        public int BuyFee { get; set; }
        [JsonPropertyName("sell_quantity")]
        public int SellQuantity { get; set; }
        [JsonPropertyName("sell_fee")]
        public int SellFee { get; set; }
        [JsonPropertyName("remaining_iso")]
        public string RemainingIso { get; set; }
        [JsonPropertyName("isOpen")]
        public bool IsOpen { get; set; }
        [JsonPropertyName("portfolio_id")]
        public object PortfolioId { get; set; }
        [JsonPropertyName("history_id")]
        public object HistoryId { get; set; }
        [JsonPropertyName("ex_portfolio_id")]
        public object ExPortfolioId { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }
        [JsonPropertyName("txid")]
        public string TransactionId { get; set; }
        [JsonPropertyName("buy_iso")]
        public string BuyIso { get; set; }
        [JsonPropertyName("sell_iso")]
        public string SellIso { get; set; }
        [JsonPropertyName("base_type")]
        public string BaseType { get; set; }
        [JsonPropertyName("base_rate")]
        public float BaseRate { get; set; }
        [JsonPropertyName("remaining_quantity")]
        public int RemainingQuantity { get; set; }
        [JsonPropertyName("blocked_quantity")]
        public int BlockedQuantity { get; set; }
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
    }
}
