using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNet45WebApp.Models
{
    public class EfCustomerRepository : ICustomerRepository
    {
        private NorthDbContext _context;
        public EfCustomerRepository()
        {
            _context = new NorthDbContext();
        }

        public IEnumerable<Customer> Customers
        {
            get
            {
                return _context.Customers;
            }
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}