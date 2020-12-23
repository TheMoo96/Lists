using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)

        {   // This is a shitty string for no reason.
            // Cound very well just be a WriteLine.
            var names = new List<string> { "Hello ", "there." };
            foreach (var name in names)
                Console.Write(name);
            Console.WriteLine();

            // Inputs the two first numbers in the Fibonacci sequence.
            // Starts a new list to hold all the values divisible by 3.
            var fibNum = new List<int> {1, 1 };
            var fibDiv = new List<int> { };

            Console.WriteLine("Following is the first 20 numbers in the Fibanacci sequence.");

            // Loops til there are 20 numbers in the fibNum list.
            // Each loop it puts pre and pre2 as the last and second to last number in the fibNum list.
            // Then adds the sum of them into the fibNum list.
            while (fibNum.Count < 20)
            {
                var pre = fibNum[fibNum.Count - 1];
                var pre2 = fibNum[fibNum.Count - 2];
                fibNum.Add(pre + pre2);
            }

            // Here it prints it all while also checking if you can divide them cleanly by 3.
            // If you can it adds it to the fibDiv list for later.
            foreach (var num in fibNum)
            {
                Console.WriteLine(num);
                if (num % 3 == 0)
                    fibDiv.Add(num);
            }

            Console.WriteLine();

            // Converts fibNum from int to decimal, 
            //then divides the last and the second to last to get an aprox value of the golden ratio. 
            decimal aprox = System.Convert.ToDecimal(fibNum[fibNum.Count - 1]) / System.Convert.ToDecimal(fibNum[fibNum.Count - 2]);
            Console.WriteLine($"The aproximisation of the irrational number for the Golden Ratio is {aprox}.");
            Console.WriteLine();

            // If none of the values were divisible by 3, it displays this.
            if (fibDiv.Count == 0)
                Console.WriteLine("None of them are divisible by 3.");

            // Otherwhise it tells you how many there are and poops them all out.
            else
            {
                Console.WriteLine($"The following {fibDiv.Count} numbers are divisible by 3.");
                foreach (var num in fibDiv)
                    Console.WriteLine(num);
            }
        }
    }
}
