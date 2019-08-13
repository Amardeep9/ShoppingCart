using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {

        DataAccessLayer objproduct = new DataAccessLayer();

        public ActionResult GetAllProducts()
        {
            List<ProductModel> lstProducts = new List<ProductModel>();
            lstProducts = objproduct.GetAllProducts().ToList();

            return View();
        }
        public ActionResult GetProductbyCategoryID()
        {
            return View();
        }
        public ActionResult GetAllCategory()
        {
            return View();
        }
    }
}