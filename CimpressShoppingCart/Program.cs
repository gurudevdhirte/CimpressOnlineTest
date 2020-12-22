using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimpressShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            ShoppingCart cart = new ShoppingCart();

            List<Product> lstProducts = new List<Product>();

            Product p1 = new Product { ProductId = 1, ProdDesc = "A", Price = 100, ProdQty = 1 };
            Product p2 = new Product { ProductId = 2, ProdDesc = "B", Price = 50, ProdQty = 1 };
            Product p3 = new Product { ProductId = 3, ProdDesc = "C", Price = 80, ProdQty = 1 };
            Product p4 = new Product { ProductId = 4, ProdDesc = "D", Price = 20, ProdQty = 1 };

            lstProducts.Add(p1);
            lstProducts.Add(p2);
            lstProducts.Add(p3);
            lstProducts.Add(p4);

            //cart.lstProducts = lstProducts;

            cart.AddToCart(lstProducts);

            cart.GetDiscount(lstProducts);

            //o1.PlaceOrder(lstProducts);
            o1.PlaceOrder(cart);

            //o1.lstProducts = lstProducts;
            //o1.GetDiscount();

            //ShoppingCart cart = new ShoppingCart();
            //cart.AddToCart(lstProducts)
        }
    }
}
