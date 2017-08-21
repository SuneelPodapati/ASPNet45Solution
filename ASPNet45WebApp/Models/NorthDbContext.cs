using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
namespace ASPNet45WebApp.Models
{
    public class NorthDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}