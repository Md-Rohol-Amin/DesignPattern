using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StrategyDesignPattern
{
    public class Restaurant
    {
        private IDiscountStrategy discountStrategy;

        /*
         * manual inject IDiscountStrategy. 
         * and it will be provide required instace of speciftc strategy class
         */
        public Restaurant(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        // get final bill after appling discount strategy
        public void GetFinalBill(int foodPrice)
        {
            Console.WriteLine($"Your net bill : {this.discountStrategy.GetDiscount(foodPrice)} ");

            Console.ReadLine();
        }       
    }
}
