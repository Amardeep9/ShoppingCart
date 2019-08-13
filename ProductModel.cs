using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDiscrip { get; set; }

        public int ProductPrice { get; set; }

        public string Productimg { get; set; }
    }
}