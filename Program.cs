using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Hello ", "there." };
            foreach (var name in names)
                Console.Write(name);
            Console.WriteLine();

            var fibNum = new List<int> {1, 1 };
            var fibDiv = new List<int> { };

            Console.WriteLine("Following is the first 20 numbers in the Fibbanachi sequence.");
            while (fibNum.Count < 20)
            {
                var pre = fibNum[fibNum.Count - 1];
                var pre2 = fibNum[fibNum.Count - 2];
                fibNum.Add(pre + pre2);
            }
            foreach (var num in fibNum)
            {
                Console.WriteLine(num);
                if (num % 3 == 0)
                    fibDiv.Add(num);
            }

            Console.WriteLine();

            decimal aprox = System.Convert.ToDecimal(fibNum[fibNum.Count - 1]) / System.Convert.ToDecimal(fibNum[fibNum.Count - 2]);
            Console.WriteLine($"The aproximisation of the irrational number for the Golden Ratio is {aprox}.");
            Console.WriteLine();

            if (fibDiv.Count == 0)
                Console.WriteLine("None of them are divisible by 3.");
            else
            {
                Console.WriteLine($"The following {fibDiv.Count} numbers are divisible by 3.");
                foreach (var num in fibDiv)
                    Console.WriteLine(num);
            }
        }
    }
}
