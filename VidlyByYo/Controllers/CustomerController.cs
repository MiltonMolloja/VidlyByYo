﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyByYo.Models;

namespace VidlyByYo.Controllers
{
    public class CustomerController : Controller
    {
        
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1 , Name = "Milton" },
                new Customer { Id = 2 , Name = "Alberto" },
                new Customer { Id = 3 , Name = "Juan" },
                new Customer { Id = 4 , Name = "Lucas" }
            };
        } 

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault( c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}