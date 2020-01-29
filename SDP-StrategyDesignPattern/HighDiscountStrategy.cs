using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StrategyDesignPattern
{
    public class HighDiscountStrategy : IDiscountStrategy
    {
        public int GetDiscount(int foodPrice)
        {
            return (int)(foodPrice - (foodPrice * 0.5));
        }
    }
}
