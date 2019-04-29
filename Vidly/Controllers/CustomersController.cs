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
        public List<Customer> customers = new List<Customer>
            {
                new Customer {Name = "Tywin", Id = 0},
                new Customer {Name = "Cersei", Id = 1},
                new Customer {Name = "Arya", Id = 2}
            };

        // GET: Customers
        public ActionResult Index()
        {
            
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }


        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            if (id - 1 <= customers.Count)
            {
                var customer = customers.Where(c => c.Id == id).FirstOrDefault();
                return View(customer);
            } else
            {
                return HttpNotFound();
            }

        }
    }
}