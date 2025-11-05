using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_2_task_assignment.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FeaturedProducts()
        {
            var featuredProducts = new List<Models.Product>
            {
                new Models.Product
                {
                    ProductID = 1,
                    Name = "Smartphone",
                    Price = 699.99,
                    Description = "A high-end smartphone with a sleek design."
                },
                new Models.Product
                {
                    ProductID = 2,
                    Name = "Laptop",
                    Price = 1299.99,
                    Description = "A powerful laptop for all your computing needs."
                },
                new Models.Product
                {
                    ProductID = 3,
                    Name = "Wireless Headphones",
                    Price = 199.99,
                    Description = "Noise-cancelling wireless headphones with superior sound quality."
                }
            };
            return View(featuredProducts);
        }

        public ActionResult Categories()
        {
            var categories = new List<Models.Category>
            {
                new Models.Category
                {
                    CategoryID = 1,
                    Name = "Electronics",
                    Description = "Latest electronic gadgets and devices."
                },
                new Models.Category
                {
                    CategoryID = 2,
                    Name = "Home Appliances",
                    Description = "Essential appliances for your home."
                },
                new Models.Category
                {
                    CategoryID = 3,
                    Name = "Books",
                    Description = "A wide range of books across various genres."
                }
            };
            return View(categories);
        }

        public ActionResult ProductReviews()
        {
            var reviews = new List<Models.Review>
            {
                new Models.Review
                {
                    CustomerName = "Alice Johnson",
                    Rating = 5,
                    Comment = "Excellent product! Highly recommend."
                },
                new Models.Review
                {
                    CustomerName = "Bob Smith",
                    Rating = 4,
                    Comment = "Good value for the price."
                },
                new Models.Review
                {
                    CustomerName = "Catherine Lee",
                    Rating = 3,
                    Comment = "Average quality, could be better."
                }
            };
            return View(reviews);
        }
    }
}