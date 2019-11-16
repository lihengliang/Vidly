using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("customers/all")]
        public ActionResult Index()
        {
            var header = "Customers";
            var customer = new List<Customer>
            {
                new Customer() {Name = "George Orwell"},
                new Customer() {Name = "Michael Scott"},
                new Customer() {Name = "Leonardo Dicaprio"},
            };
            var viewModel = new AllCustomersViewModel()
            {
                Header = header,
                Customers = customer
            };
            return View(viewModel);
        }
    }
}