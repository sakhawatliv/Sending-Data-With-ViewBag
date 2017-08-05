using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingViewBag.Database;
using UsingViewBag.Models;

namespace UsingViewBag.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerDbContext.Customers.Add(customer);
            }
            ViewBag.Customer = customer;
            return View();
        }
    }
}