using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
           
                List<int> data = new List<int>();
                Menu x = new Menu();
                x.input(data);
                x.Select(data);
                

        }
    }
}
