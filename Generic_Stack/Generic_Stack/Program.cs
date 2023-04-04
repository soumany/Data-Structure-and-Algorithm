using System;
using System.Collections.Generic; //Generic stack definition is included into our project space
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
        }
    }
}
