using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.CSharp.Learning.Basics
{
    internal class Conditionals
    {
        /*
         Suppose you need to quickly determine whether a customer's purchase is eligible for a promotional discount. 
        The details for the promotion indicate that when a purchase value is greater than $1000, the purchase is eligible for a $100 discount. 
        If the purchase amount is $1000 or less, the purchase is eligible for a $50 discount.
         */
        void implementConditionalOperator()
        {
            int saleAmount = 1001;
            // int discount = saleAmount > 1000 ? 100 : 50;

            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
        }

        /*
         Use the Random class to generate a value.

        Consider the range of numbers that is required.

        Based on the value generated, use the conditional operator to display either heads or tails.

        There should be a 50% chance that the result is either heads or tails.

        Your code should be easy to read, but with as few lines as possible.

        You should be able to accomplish the desired result in three lines of code.
        */
        void validateRandomWithConditionaOperator() {
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");
        }
    }
}
