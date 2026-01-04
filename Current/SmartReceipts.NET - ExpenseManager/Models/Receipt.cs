namespace SmartReceipts.NET.Models
{
    public class Receipt
    {
        public Guid Id { get; set; }
        public string FileName { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public DateTime UploadedAt { get; set; }
    }
}
