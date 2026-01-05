using Microsoft.AspNetCore.Mvc;
using SmartReceipts.NET.Data;
using SmartReceipts.NET.Models; // Ensure this using is present if Expense is in Models namespace

namespace SmartReceipts.NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ExpenseController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var expenses = _db.Expenses
                .OrderByDescending(e => e.ExpenseDate)
                .ToList();

            return Ok(expenses);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Expense expense)
        {
            if (expense.ReceiptId == Guid.Empty)
            {
                return BadRequest("ReceiptId is required.");
            }

            if (!_db.Receipts.Any(r => r.Id == expense.ReceiptId))

            {
                return BadRequest("ReceiptId does not exist");
            }

            if (string.IsNullOrWhiteSpace(expense.Merchant))
            {
                return BadRequest("Merchant is required");
            }

            if (expense.Total <= 0)
            {
                return BadRequest("Ttoal must be > 0");
            }

            //server settings so the client does not alter. 
            expense.Id = Guid.NewGuid();
            expense.CreatedAt = DateTime.UtcNow;

            //if the date is not set, we will have a default date to today
            if (expense.ExpenseDate == default)
            {
                expense.ExpenseDate = DateTime.UtcNow.Date;
            }
            _db.Expenses.Add(expense);
            await _db.SaveChangesAsync();

            return Ok(expense);
        }
    }
}