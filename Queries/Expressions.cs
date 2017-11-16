using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Expressions
    {
        public static void Ascending(List<int> data)
        {
            var asc = data.OrderBy(x => x);
            Console.Write("Ascending:");
            foreach (int y in asc)
            {
                Console.Write(y + " ");
            }
            Console.WriteLine();
        }

        public static void Descending(List<int> data)
        {
            var desc = data.OrderByDescending(x => x);
            Console.Write("Descending:");
            foreach (int y in desc)
            {
                Console.Write(y + " ");
            }
            Console.WriteLine();
        }



        public static void Average(List<int> data)
        {
            Console.WriteLine("Average is: {0} ", data.Average());
        }
        
        public static void Even(List<int> data)
        {
          var even =  data.FindAll(x => x % 2 == 0);
            Console.Write("Even numbers:");
            foreach(int x in even)
            {
                Console.Write(x+" ");
            }
            Console.Write("(times:" + even.Count + ")");

           

            Console.WriteLine();
        }

        public static void Odd(List<int> data)
        {
            var odd = data.FindAll(x => x % 2 == 1);
            Console.Write("Odd numbers:");
            foreach (int x in odd)
            {
                Console.Write(x + " ");
            }
            Console.Write("(times:" + odd.Count + ")");

            Console.WriteLine();
        }

        public static void Max(List<int> data)
        {
            var z = data.Max();
            Console.WriteLine("Maximum is:" + z);
        }
        public static void Min(List<int> data)
        {
            var y = data.Min();
            Console.WriteLine("Minimum is:" + y);
        }
        public static void Positive(List<int> data)
        {
            var pos = data.FindAll(x => x>0);
            Console.Write("Positve numbers:");
            foreach (int x in pos)
            {
                Console.Write(x + " ");
            }
            Console.Write("(times:" + pos.Count + ")");

            Console.WriteLine();
        }
        public static void Negative(List<int> data)
        {
            var neg = data.FindAll(x => x < 0);
            Console.Write("Negative numbers:");
            foreach (int x in neg)
            {
                Console.Write(x + " ");
            }
            Console.Write("(times:" + neg.Count + ")");

            Console.WriteLine();
        }





    }
}
