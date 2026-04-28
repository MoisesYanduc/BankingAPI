using Microsoft.AspNetCore.Mvc;
using BankingAPI.Data;
using BankingAPI.Models;
using System.Linq;

namespace BankingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // 💰 DEPOSIT
        [HttpPost("deposit")]
        public IActionResult Deposit(int userId, decimal amount)
        {
            var user = _context.Users.Find(userId);
            if (user == null) return NotFound("User not found");

            if (amount <= 0)
                return BadRequest("Invalid amount");

            user.Balance += amount;

            _context.Transactions.Add(new Transaction
            {
                UserId = userId,
                Type = "Deposit",
                Amount = amount,
                Date = DateTime.Now
            });

            _context.SaveChanges();
            return Ok(user);
        }

        // 💸 WITHDRAW
        [HttpPost("withdraw")]
        public IActionResult Withdraw(int userId, decimal amount)
        {
            var user = _context.Users.Find(userId);
            if (user == null) return NotFound("User not found");

            if (amount <= 0)
                return BadRequest("Invalid amount");

            if (user.Balance < amount)
                return BadRequest("Insufficient balance");

            user.Balance -= amount;

            _context.Transactions.Add(new Transaction
            {
                UserId = userId,
                Type = "Withdraw",
                Amount = amount,
                Date = DateTime.Now
            });

            _context.SaveChanges();
            return Ok(user);
        }

        // 🧾 HISTORY
        [HttpGet("history/{userId}")]
        public IActionResult GetHistory(int userId)
        {
            var history = _context.Transactions
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.Date)
                .ToList();

            return Ok(history);
        }

        // 🔄 TRANSFER
        [HttpPost("transfer")]
        public IActionResult Transfer(int senderId, int receiverId, decimal amount)
        {
            var sender = _context.Users.Find(senderId);
            var receiver = _context.Users.Find(receiverId);

            if (sender == null || receiver == null)
                return NotFound("User not found");

            if (amount <= 0)
                return BadRequest("Invalid amount");

            if (sender.Balance < amount)
                return BadRequest("Insufficient balance");

            sender.Balance -= amount;
            receiver.Balance += amount;

            _context.Transactions.Add(new Transaction
            {
                UserId = senderId,
                Type = "Transfer Sent",
                Amount = amount,
                Date = DateTime.Now
            });

            _context.Transactions.Add(new Transaction
            {
                UserId = receiverId,
                Type = "Transfer Received",
                Amount = amount,
                Date = DateTime.Now
            });

            _context.SaveChanges();

            return Ok("Transfer successful");
        }
    }
}