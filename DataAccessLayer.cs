using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoppingCart.Models
{
    public class DataAccessLayer
    {
        string connectionString = "Data Source=DELL;Initial Catalog=MVCCRUD; Integrated Security=true;";

        public IEnumerable<ProductModel> GetAllProducts()
        {
            List<ProductModel> lstproduct = new List<ProductModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllProducts", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ProductModel products = new ProductModel();

                    products.ProductId= Convert.ToInt32(rdr["ProductId"]);
                    products.ProductName= rdr["ProductName"].ToString();
                    products.ProductDiscrip= rdr["ProductDiscrip"].ToString();
                    products.ProductPrice= Convert.ToInt32(rdr["ProductPrice"]);

                    lstproduct.Add(products);
                }
                con.Close();
            }
            return lstproduct;
        }

    }
}