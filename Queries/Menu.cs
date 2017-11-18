using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
     class Menu
    {
        public void input(List<int> data)
        {
            int max, min, n;
            try
            {
                
                Random random = new Random();
                Console.Write("Insert the count of random numbers:");
                n = int.Parse(Console.ReadLine());
                Console.Write("Insert the Min value of sequence:");
                min = int.Parse(Console.ReadLine());
                Console.Write("Insert the Max value of sequence:");
                max = int.Parse(Console.ReadLine());

                if (n <= 0 || min > max)
                {
                    Console.WriteLine("Count of the numbers should be greater  to zero and max greater or equal to min");
                    data.Clear();
                    input(data);
                }

                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        data.Add(random.Next(min, max + 1));
                    }
                }
            }
            catch(Exception)
            {
                

                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Insert only integers");
                Console.ResetColor();
                data.Clear();
                input(data);

            }
           


        }


        public void Select(List<int> data)
        {
            Console.Write("\nThe sequence of random numbers are:");
            Display(data);
            Console.WriteLine("\n\n\nPlease enter an option from the menu");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("exit new data\n1.Average 2.Max 3.Min 4.Even 5.Odd 6.Ascending sequence "+
                "7.Descending sequence 8.Positive Numbers 9.Negative Numbers 10.Find a number if exists\n\n");
            Console.ResetColor();

            

            string input;
            while (true)
            {
                Console.WriteLine("\n");
              Console.Write("Option:");
              input = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                switch (input)
                {
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "new data":
                        data.Clear();
                        Console.ResetColor();
                        Menu y = new Menu();
                        y.input(data);
                        y.Select(data);
                        break;
                    case "1":
                        Expressions.Average(data);
                        break;
                    case "2":
                        Expressions.Max(data);
                        break;
                    case "3":
                        Expressions.Min(data);
                        break;
                    case "4":
                        Expressions.Even(data);
                        break;
                    case "5":
                        Expressions.Odd(data);
                        break;
                    case "6":
                        Expressions.Ascending(data);
                        break;
                    case "7":
                        Expressions.Descending(data);
                        break;
                    case "8":
                        Expressions.Positive(data);
                        break;
                    case "9":
                        Expressions.Negative(data);
                        break;
                    case "10":
                        Expressions.find(data);
                        break;
                }
                Console.ResetColor();
            }

        }


        public static void Display(List<int> T) 
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (int x in T)
            {
                Console.Write(x + " ");
            }

            Console.ResetColor();
            
           
           
        }


     
    }
}
