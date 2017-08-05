using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Configuration;
using UsingViewBag.Models;

namespace UsingViewBag.Database
{
    public class CustomerDbContext
    {
        static CustomerDbContext()
        {
            Customers = new List<Customer>(); 

        }

        public static List<Customer> Customers { get; set; }
    }
}
