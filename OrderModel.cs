using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string UserId { get; set; }

        public DateTime Purchasedate { get; set; }

        public DateTime Canceldate { get; set; }


    }
}