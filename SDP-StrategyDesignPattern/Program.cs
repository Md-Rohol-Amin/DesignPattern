using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StrategyDesignPattern
{
    class Program
    {
        /*
         * AGENDA:
         * 
         * 
         * Strategy - Strategy is a plan of an action by which we can achieve a certain goal.It can be about any things.
         *
         * Strategy Design Pattern - This pattern allows a client to choose an algorithm from a family of algorithms.At 
         *                           run-time and gives it a simple way to access it. Moreover encapsulate each one,
         *                           and make them interchangeable.
         *                           Easily can says, Strategy lets to choose an algorithm very independently for client that's he want.
         *                           
         * When to use : When we have to need to change a plan to another plan then we can easyly use this pattern.Like discount 
         *               strategy for any resturant or shopping mall etc. Suppose a resturan discount offer has saterday to sunday
         *               50%, wednesday 10% and others day no discount (0%).Then algorithm will be change automatically.
         *               that means algorithm changeable upon client decision, So it is fully achieve by SDP.
         *               
         * Demo : Lets start              
         *               
         */

        static void Main(string[] args)
        {
            Console.Write("Enter the day name first 3 charaters :");
            string day = Console.ReadLine();
            Console.Write("Enter the Food Price : ");
            int foodPrice = Convert.ToInt32(Console.ReadLine());

            if (day.ToLower().Equals("sat") || day.ToLower().Equals("sun"))
            {
                // get instace of HighDiscountStrategy class
                Restaurant rs = new Restaurant(new HighDiscountStrategy());
                rs.GetFinalBill(foodPrice);
            }
            else if (day.ToLower().Equals("wed"))
            {
                // get instace of LowDiscountStrategy class
                Restaurant rs = new Restaurant(new LowDiscountStrategy());
                rs.GetFinalBill(foodPrice);
            }
            else
            {
                // get instace of NoDiscountStrategy class
                Restaurant rs = new Restaurant(new NoDiscountStrategy());
                rs.GetFinalBill(foodPrice);
            }
        }
    }
}
