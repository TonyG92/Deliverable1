using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // array for holding the dollar amounts
            double[] dollarAmounts = new double[3];
            
            // loop through the input and fill the array
            for(int i=0;i < dollarAmounts.Count(); i++)
            {
                Console.Write("Enter a dollar amount: ");
                // convert the string input to double
                dollarAmounts[i] = Convert.ToDouble(Console.ReadLine());
            }


            // calculate the total
            double total = Total(dollarAmounts);
            Console.WriteLine("The total is: " + total);

            // calculate the average
            double average = Average(dollarAmounts);
            Console.WriteLine("The average is: " + average);

            // calculate the max value
            double max = MaxValue(dollarAmounts);
            Console.WriteLine("The max value is: " + max);

            // calculate the min value
            double min = MinValue(dollarAmounts);
            Console.WriteLine("The min value is: " + min);

            // display the total formatted for specific cultures and currencies.
            Console.WriteLine("US: " + total.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Swedish: " + total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("Japanese: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: " + total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

            Console.Write("Press any key to close...");
            Console.ReadKey();
        }

        static double Total(double[] amounts)
        {
            // set result to 0
            double result = 0.0;
            
            // add all amounts into result
            foreach(double amount in amounts)
            {
                result += amount;
            }
            
            return result;
        }

        static double Average(double[] amounts)
        {
            // calculate the total and divide by the number of amounts
            return Total(amounts) / amounts.Count();
            
        }

        static double MaxValue(double[] amounts)
        {
            // set the result to be the first amount in the array
            double result = amounts[0];

            // loop through the amounts
            foreach(double amount in amounts)
            {
                // check if result is less than the amount
                if(amount > result)
                {
                    // set the result to the amount
                    result = amount;
                }
            }
            
            return result;
        }

        static double MinValue(double[] amounts)
        {
            // set the result to be the first amount in the array
            double result = amounts[0];

            // loop through the amounts
            foreach (double amount in amounts)
            {
                // check if result is more than the amount
                if (amount < result)
                {
                    // set the result to the amount
                    result = amount;
                }
            }

            return result;
        }


    }                   
}

