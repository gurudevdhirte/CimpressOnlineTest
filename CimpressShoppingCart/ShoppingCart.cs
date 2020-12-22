using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimpressShoppingCart
{
    public class ShoppingCart
    {
        AllItemDiscount allItemDiscount = new AllItemDiscount();
        NextItemDiscount nextItemDiscount = new NextItemDiscount();

        public int TotalDiscount { get; set; }
        public int CartId { get; set; }

        public void PlaceOrder()
        {
            //Order order = new Order(new AllItemDiscount());
            //order.BillingAmount = 1000;
            //Console.WriteLine("Applying Discount");
            //order.GetDiscount();
        }

        public List<Product> lstProducts { get; set; }

        public int GetDiscount(List<Product> lstProducts)
        {
            //int discount = 0;
            //return _strategy.GetDiscount(BillingAmount);
            TotalDiscount = allItemDiscount.CalculateDiscount(lstProducts);
            TotalDiscount = TotalDiscount + nextItemDiscount.CalculateDiscount(lstProducts);

            return TotalDiscount;
        }

        public void AddToCart(List<Product> products)
        {
            this.lstProducts = products;
            Console.WriteLine("Added Products to Cart");
        }
    }

}
