using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNet45WebApp.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Customers { get; }
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void SaveChanges();
    }
}
