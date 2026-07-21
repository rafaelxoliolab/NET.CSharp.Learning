using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.CSharp.Learning.Basics
{
    internal class Strings
    {
        void StringFormatInterpolation()
        {
            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Shares: {productShares:N3} Product");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Billed: {total:C}");
        }

        void StringFormatUsingInterpolation()
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);
        }

        void StringIndexOfAny()
        {
            char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y',
                       'A', 'E', 'I', 'O', 'U', 'Y' };
            String s = "The long and winding road...";
            Console.WriteLine("The first vowel in \n   {0}\nis found at position {1}",
                              s, s.IndexOfAny(chars) + 1);
        }


        string ReverseSentence(string input)
        {
            string result = "";
            string[] words = input.Split(" ");
            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }
            return result.Trim();
        }

        string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }

        string ReverseSentenceUsingArray(string input)
        {
            string[] words = input.Split(" ");
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        string ReverseWordUsingArray(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
