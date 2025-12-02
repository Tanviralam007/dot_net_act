using lab_5_assignment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_5_assignment.DTOs;

namespace lab_5_assignment.Controllers
{
    public class ProductController : Controller
    {
        public readonly ProductDBEntities db = new ProductDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        // manual approach of DTO manual mapping against each EF table classes
        // 1
        public static Product Convert(ProductDTO p)
        {
            return new Product
            {
                Name = p.Name,
                Price = p.Price,
                Qty = p.Qty,
                C_Id = p.C_Id,
            };
        }
        // 2
        public static ProductDTO Convert(Product p)
        {
            return new ProductDTO
            {
                Name = p.Name,
                Price = p.Price,
                Qty = p.Qty,
                C_Id = p.C_Id
            };
        }
        // 3
        public static List<ProductDTO> Convert(List<Product> list)
        {
            var data = new List<ProductDTO>();
            foreach(var item in list)
            {
                data.Add(Convert(item));
            }
            return data;
        }

        [HttpGet]
        public ActionResult ProductList()
        {
            var products = db.Products.ToList();
            return View(Convert(products));
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View(new ProductDTO());
        }

        [HttpPost]
        public ActionResult Create(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                var p = Convert(product);
                db.Products.Add(p);
                db.SaveChanges();
                return RedirectToAction("ProductList");
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = db.Products.Find(id);
            ViewBag.Categories = db.Categories.ToList();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        
    }
}