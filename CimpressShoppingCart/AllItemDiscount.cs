using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimpressShoppingCart
{
    public class AllItemDiscount : CouponDiscount
    {
        //public AllItemDiscount()
        //{
        //    CouponDiscount = "All Item Discount";
        //}

        //public string CouponDiscount { get; set; }

        public override int CalculateDiscount(List<Product> lstProducts)
        {
            Console.WriteLine("Applying Discount on All items");
            int BillAmount  = lstProducts.Sum(x => x.Price);
            //return Convert.ToInt32(BillAmount - (BillAmount * 0.1));
            Console.WriteLine("Applied Discount of " + (BillAmount * 0.1) );
            return Convert.ToInt32((BillAmount * 0.1));
        }
    }

}
