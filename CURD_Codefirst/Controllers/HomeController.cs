using CURD_Codefirst.Models;
using CURD_Codefirst.Models.Viwe_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CURD_Codefirst.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbcontext Dbcontext = new ApplicationDbcontext();

        // GET: Home
        public ActionResult Index()
        {
            //var data = Dbcontext.Products.ToList();
            var products = (from p in Dbcontext.Products
                            join
                            c in Dbcontext.catagries
                            on p.catagrie.Id equals c.Id
                            select new productlistviwemodel()
                            {
                                Pid = p.Pid,
                                Pname = p.Pname,
                                Contity = p.Contity,
                                Price = p.Price,
                                Descri = p.Descri,
                                catagrie = c.name
                            });

            return View(products);
        }
        public ActionResult create()
        {
            var cats = Dbcontext.catagries.ToList();
            ViewBag.cats = cats;
            return View();
        }
        [HttpPost]
        public ActionResult create(Product emp)
        {
            Dbcontext.Products.Add(emp);
                Dbcontext.SaveChanges();
            return RedirectToAction("index");

        }
        public ActionResult Delete(int id)
        {
            var product = Dbcontext.Products.SingleOrDefault(e => e.Pid == id);
            Dbcontext.Products.Remove(product);
            Dbcontext.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Edit(int id)
        {
            var product = Dbcontext.Products.SingleOrDefault(e => e.Pid == id);
          
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Product emp)
        {
            Dbcontext.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            Dbcontext.SaveChanges();
            return RedirectToAction("index");

        }

    }
}