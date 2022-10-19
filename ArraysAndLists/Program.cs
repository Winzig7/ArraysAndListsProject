using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var oddNum = new List<int>();
            var evenNum = new List<int>();
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var Num in numbers) 
            {
                if (Num % 2 == 0) 
                evenNum.Add (Num);
                else 
                oddNum.Add (Num);   
            }
            foreach (int Num in oddNum)
            {
                Console.WriteLine (Num);
            }
            foreach (int Num in evenNum)
            {
                Console.WriteLine (Num);
            }
            /* Now using foreach or for loops,
             * display each List of even and odd numbers
            
             * Try to be creative in your display
             */
        }
    }
}
