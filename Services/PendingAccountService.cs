using BankingSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace BankingSystem.Services
{
    public class PendingAccountService
    {
        CustomerService customerService = new CustomerService();

        private static List<PendingAccount> accounts;
        public PendingAccountService()
        {
            if (accounts == null)
            {
                accounts = new List<PendingAccount>();

                accounts.Add(new PendingAccount
                {
                    Id = 1,
                    FullName = "Juan Dela Cruz",
                    Username = "juan123",
                    Contact = "09123456789",
                    Deposit = 5000,
                    Address = "Cebu City",
                    Status = "Pending"
                });

                accounts.Add(new PendingAccount
                {
                    Id = 2,
                    FullName = "Maria Santos",
                    Username = "maria12",
                    Contact = "09987654321",
                    Deposit = 10000,
                    Address = "Davao City",
                    Status = "Pending"
                });
            }
        }

        public List<PendingAccount> GetPendingAccounts()
        {
            return accounts;
        }

        public void ApproveAccount(int id)
        {
            PendingAccount account =
                accounts.FirstOrDefault(a => a.Id == id);

            if (account != null)
            {
                Customer customer = new Customer();

                customer.Id = account.Id;
                customer.FullName = account.FullName;
                customer.Username = account.Username;
                customer.Contact = account.Contact;
                customer.Balance = account.Deposit;
                customer.Address = account.Address;
                customer.Status = "Active";

                customerService.AddCustomer(customer);

                accounts.Remove(account);
            }
        }

        public void RejectAccount(int id)
        {
            PendingAccount account =
                accounts.FirstOrDefault(a => a.Id == id);

            if (account != null)
            {
                accounts.Remove(account);
            }
        }
        public List<PendingAccount> SearchAccounts(string keyword)
        {
            return accounts.Where(a =>
                a.FullName.ToLower().Contains(keyword.ToLower()) ||
                a.Username.ToLower().Contains(keyword.ToLower())
            ).ToList();
        }
        public void AddPendingAccount(PendingAccount account)
        {
            accounts.Add(account);
        }
    }
}