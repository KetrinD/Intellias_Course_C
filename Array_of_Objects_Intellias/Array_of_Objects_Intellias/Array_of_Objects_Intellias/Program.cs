
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Of_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Table[] Table_1 = new Table[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Table_1[i] = new Table(random.Next(50, 200), random.Next(50, 200));
                Table_1[i].ShowData();
            }

            Console.ReadKey();
        }
    }
}