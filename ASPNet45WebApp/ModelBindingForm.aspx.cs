using System;
using ASPNet45WebApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;

namespace ASPNet45WebApp
{
    public partial class ModelBindingForm : System.Web.UI.Page
    {
        EfCustomerRepository _customer;

        protected void Page_Load(object sender, EventArgs e)
        {
            _customer = new EfCustomerRepository();
        }

        public List<string> CountryDropDownList_GetCountry(object sender, EventArgs e)
        {
            var result = new List<string>();
            result.Add("All");
            result.AddRange(_customer.Customers.Select(c => c.Country).Distinct().ToList());
            return result;
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<ASPNet45WebApp.Models.Customer> CustomerGridView_GetData([Control] string country)
        {
            var result = _customer.Customers.ToList();
            if (country != null)
            {
                if (country != "All")
                {
                     return result.Where(c => c.Country == country).AsQueryable();
                }
            }
            return result.AsQueryable();
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void CustomerGridView_UpdateItem(string CustomerID)
        {
            ASPNet45WebApp.Models.Customer item = _customer.Customers.FirstOrDefault(c=>c.CustomerID == CustomerID);
            if (item == null)
            {
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", CustomerID));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                _customer.SaveChanges();
            }
        }
    }
}