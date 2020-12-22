using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimpressShoppingCart
{
    public class Order
    {
        //public ICouponDiscount _strategy;

        //public Order(ICouponDiscount strategy)
        //{
        //    _strategy = strategy;
        //}

        AllItemDiscount allItemDiscount = new AllItemDiscount();
        NextItemDiscount nextItemDiscount = new NextItemDiscount();

        public int BillingAmount { get; set; }

        //public int GetDiscount(List<Product> lstProducts)
        //{
        //    int discount = 0;
        //    //return _strategy.GetDiscount(BillingAmount);
        //    discount = allItemDiscount.CalculateDiscount(lstProducts);
        //    discount = discount + nextItemDiscount.CalculateDiscount(lstProducts);

        //    return discount;
        //}

        //public List<Product> lstProducts { get; set; }

        //public void PlaceOrder(List<Product> lstProducts)
        public void PlaceOrder(ShoppingCart cart)
        {
            Console.WriteLine("Placing Order");

            int TotalPrice = cart.lstProducts.Sum(x => x.Price);

            Console.WriteLine("Total Price Of Products : "  + TotalPrice);

            //Console.WriteLine("Applying Discount");

            //int discount = GetDiscount(lstProducts);           

            string totalDiscountAmount = Convert.ToString(TotalPrice - cart.TotalDiscount);

            Console.WriteLine("Final Price After applying discount is " + totalDiscountAmount);

            Console.WriteLine("Order Placed successfully");
        }
    }

}
