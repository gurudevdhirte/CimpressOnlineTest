using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimpressShoppingCart
{
    public class NextItemDiscount : CouponDiscount
    {
        public override int CalculateDiscount(List<Product> lstProducts)
        {
            Console.WriteLine("Applying Discount on next items");
            int BillAmount = lstProducts.Sum(x => x.Price);
            int discountAmount = 10; // lstProducts.even(x => x.Price);
                                      //return Convert.ToInt32(BillAmount - (discountAmount));

            Console.WriteLine("Applied Discount of " + (discountAmount));

            return discountAmount;
        }
    }

}
