using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimpressShoppingCart
{
    public abstract class CouponDiscount
    {
        string CouponType { get; set; }
        public abstract int CalculateDiscount(List<Product> lstProducts);
    }

}
