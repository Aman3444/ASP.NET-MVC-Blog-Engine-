using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Diagnostics;

namespace CS_Midterm
{
    class Program
    {

        //Use LINQ or Lambda expressions to:
        //    Select the Maximum value.
        //    Order the numbers in the array
        //    Count the number of entries equal to 1
        //    Order the entries in the array and take the top 3
        //    Find the average value in the array.
        //    Sum up the values of the array.
        //    Cast the array to a 'List<int>()'
        //    Order the entries in descending order.

        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;

            var numbers = new int[] { 1, 6, 3, 8, 9, 10, 1 };

            var maxValue = numbers.Max();

            Console.WriteLine("1. " + maxValue);

            var orderedArray = (from i in numbers orderby i ascending select i).ToArray();

            Console.Write("2. ");

            for (int i = 0; i < orderedArray.Length; i++)
            {
                Console.Write(orderedArray[i] + ", ");
                if (i == numbers.Length - 1)
                    Console.WriteLine("\b");

            }

            var numOne = numbers.Where(o => o == 1).Count();
            Console.WriteLine("3. " + numOne);

            var topThree = (from i in numbers orderby i descending select i).Take(3).ToArray();

            Console.WriteLine("4. " + topThree[0] + " " + topThree[1] + " " + topThree[2]);

            var average = numbers.Average();

            Console.WriteLine("5. " + average);

            var sum = numbers.Sum();

            Console.WriteLine("6. " + sum);

            var numbersList = numbers.ToList<int>();

            var descendingArray = numbers.OrderByDescending(n => n).ToArray();

            Console.Write("8. ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(descendingArray[i] + ", ");
                //if (i == descendingArray.Length - 1)
                  //  Console.WriteLine("");

                
            }

            

        }

    }
}
