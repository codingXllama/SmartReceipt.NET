namespace SmartReceipts.NET.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        public Guid ReceiptId { get; set; }
        public string Merchant { get; set; } = "";

        public string Category { get; set; } = "";
        public DateTime ExpenseDate { get; set; }

        public decimal Total { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
