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
        string header = "Customers";
        List<Customer> customer = new List<Customer>
        {
            new Customer() {Id = 1, Name = "George Orwell"},
            new Customer() {Id = 2, Name = "Michael Scott"},
            new Customer() {Id = 3, Name = "Leonardo Dicaprio"},
        };
        // GET: Customers
        [Route("customers/all")]
        public ActionResult Index()
        {
            var viewModel = new AllCustomersViewModel()
            {
                Header = header,
                Customers = customer
            };
            return View(viewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult Customer(int id)
        {
            var viewModel = new Customer()
            {
                Name = customer.SingleOrDefault(item => item.Id == id).Name
            };
            return View(viewModel);
        }
    }
}