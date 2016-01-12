﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public string Index() {
            return "Navigate to a URL to show an example.";
        }

        public ViewResult CreateProduct() {
            /*//create new product object
            Product myProduct = new Product();
            //set the property values
            myProduct.ProductID = 100;
            myProduct.Name = "Kayak";
            myProduct.Description = "A boat for one person.";
            myProduct.Price = 275M;
            myProduct.Category = "Watersports";*/

            //create and populate a new Product object
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person.",
                Price = 275M,
                Category = "Watersports"
            };
            return View("Result",
                (object)String.Format("Category: {0}", myProduct.Category));
        }

        /*public ViewResult AutoProperty() {
            //create a new Product object
            Product myProduct = new Product();

            //set the property value
            myProduct.Name = "Kayak";

            //get the property
            string productName = myProduct.Name;

            //generate the result
            return View("Result", (object)String.Format("Product name: {0}", productName));
        }*/
    }
}