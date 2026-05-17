using BankingSystem.Models;
using System.Collections.Generic;

namespace BankingSystem.Services
{
    public class CustomerService
    {
        private static List<Customer> customers;

        public CustomerService()
        {
            if (customers == null)
            {
                customers = new List<Customer>();
            }
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
    }
}