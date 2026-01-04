using Microsoft.AspNetCore.Mvc;
using SmartReceipts.NET.Data;
using SmartReceipts.NET.Models;

namespace SmartReceipts.NET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReceiptsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ReceiptsController(AppDbContext db)
        {
            _db = db;
        }

        //GET/api/receipts
        [HttpGet]
        public IActionResult GetAll()
        {
            var receipts = _db.Receipts
                .OrderByDescending(r => r.UploadedAt)
                .ToList();

            return Ok(receipts);
        }


        // POST /api/receipts
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Upload([FromForm] UploadReceiptRequest request)

        {
            var file = request.File;

            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            var uploadsFolder = Path.Combine("wwwroot", "uploads");
            Directory.CreateDirectory(uploadsFolder);

            var receipt = new Receipt
            {
                Id = Guid.NewGuid(),
                FileName = file.FileName,
                UploadedAt = DateTime.UtcNow
            };

            var extension = Path.GetExtension(file.FileName);
            if (string.IsNullOrWhiteSpace(extension))
            {
                extension = ".png";
            }

            var savedFileName = receipt.Id + extension;
            var fullPath = Path.Combine(uploadsFolder, savedFileName);

            using (var stream = System.IO.File.Create(fullPath))
            {
                await file.CopyToAsync(stream);
            }
            receipt.ImageUrl = "/uploads/" + savedFileName;

            _db.Receipts.Add(receipt);
            await _db.SaveChangesAsync();

            return Ok(receipt);
        }

    }
}
