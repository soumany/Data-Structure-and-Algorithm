using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fruit = new[] { "Apple", "Grape", "Banana" };
            var result = new string[fruit.Length];
            for (int i = result.Length-1; i >= 0;)
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }
}
