using ASPNet45WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNet45WebApp
{
    public partial class StronglyTypedControlForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EfCustomerRepository efCustomer = new EfCustomerRepository();
            CustRepeater.DataSource = efCustomer.Customers.ToList();
            CustRepeater.DataBind();
        }
    }
}