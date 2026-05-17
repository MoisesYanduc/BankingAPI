using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Models
{
    public class PendingAccount
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Contact { get; set; }

        public string Address { get; set; }

        public decimal Deposit { get; set; }

        public string Status { get; set; }
    }
}