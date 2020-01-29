using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StrategyDesignPattern
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public int GetDiscount(int foodPrice)
        {
            return (foodPrice);
        }
    }
}
