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
            var asc = data.OrderBy(x => x).ToList();
            Console.Write("Ascending:");

            Menu.Display(asc);
        }

        public static void Descending(List<int> data)
        {
            var desc = data.OrderByDescending(x => x).ToList();
            Console.Write("Descending:");

            Menu.Display(desc);
           
        }



        public static void Average(List<int> data)
        {
            Console.Write("Average is:{0}", data.Average());
        }
        
        public static void Even(List<int> data)
        {
          var even =  data.FindAll(x => x % 2 == 0 || -x%2 ==0 ).ToList();  //Negative numbers are also classified as Even and Odd Numbers.
            Console.Write("Even numbers:");
            Menu.Display(even);
            Console.Write("(times:" + even.Count + ")");

           
            
        }

        public static void Odd(List<int> data)
        {
            var odd = data.FindAll(x => x % 2 == 1 || -x%2 == 1 ).ToList();
            Console.Write("Odd numbers:");
            Menu.Display(odd);
            Console.Write("(times:" + odd.Count + ")");

            
        }

        public static void Max(List<int> data)
        {
            var z = data.Max();
            Console.Write("Maximum is:" + z);
        }
        public static void Min(List<int> data)
        {
            var y = data.Min();
            Console.Write("Minimum is:" + y);
        }
        public static void Positive(List<int> data)
        {
            var pos = data.FindAll(x => x>0).ToList();
            Console.Write("Positve numbers:");
            Menu.Display(pos);
            Console.Write("(times:" + pos.Count + ")");

           
        }
        public static void Negative(List<int> data)
        {
            var neg = data.FindAll(x => x < 0).ToList();
            Console.Write("Negative numbers:");
            Menu.Display(neg);
            Console.Write("(times:" + neg.Count + ")");

           
        }

        public static void find(List<int> data)
        {
            int num;
            Console.Write("Insert the number you are looking for:");
            try
            {
                num = int.Parse(Console.ReadLine());

                var search = from x in data
                           where x == num
                           select true;

                Console.Write(search.FirstOrDefault());
            }
            catch(Exception)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Insert only integers");
                Console.ResetColor();
                find(data);
               
            }
           
    }


      




    }
}
