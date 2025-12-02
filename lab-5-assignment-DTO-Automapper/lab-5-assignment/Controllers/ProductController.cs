using AutoMapper;
using lab_5_assignment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_5_assignment.DTOs;
using System.Data.Entity;

namespace lab_5_assignment.Controllers
{
    public class ProductController : Controller
    {
        public readonly ProductDBEntities db = new ProductDBEntities();

        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDTO>().ReverseMap();
            });
            return new Mapper(config);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ProductList()
        {
            var products = db.Products.ToList();
            var mapper = GetMapper();
            var listOfProducts = mapper.Map<List<ProductDTO>>(products); // Product Entity is mapping to DTO
            return View(listOfProducts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Categories = db.Categories.ToList();
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(ProductDTO product)
        {
            if (ModelState.IsValid)
            {
                var mapper = GetMapper();
                var createProduct = mapper.Map<Product>(product); // DTO is mapping To Product Entity
                db.Products.Add(createProduct);
                db.SaveChanges();
                return RedirectToAction("ProductList");
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            var mapper = GetMapper();
            var productDetails = mapper.Map<ProductDTO>(product); // Product Entity is mapping to DTO
            return View(productDetails);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = db.Products.Find(id);
            var mapper = GetMapper();
            var productDetails = mapper.Map<ProductDTO>(product); // Product Entity is mapping to DTO
            ViewBag.Categories = db.Categories.ToList();
            return View(productDetails);
        }

        [HttpPost]
        public ActionResult Edit(ProductDTO product)
        {
            var mapper = GetMapper();
            var editProduct = mapper.Map<Product>(product); // DTO is mapping to Product Entity
            db.Products.Add(editProduct);
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