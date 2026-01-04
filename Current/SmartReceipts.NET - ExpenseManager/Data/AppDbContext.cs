using Microsoft.EntityFrameworkCore;
using SmartReceipts.NET.Models;

namespace SmartReceipts.NET.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<Receipt> Receipts => Set<Receipt>();
    }
}
