using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDAlgo
{
    internal class Program
    { //the func must be inside the internal class 
        static int GCD(int a, int b) /*must call static cuz of inside the static class when call to use inside static void Main(string[] args)  
                                      * - can use it without the object 
                                      - int a, & b are local variables*/
        { //agorithm starts 
            int temp;
            while ((a % b) > 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return b; //b is the answer 
        }
        static void Main(string[] args)
        {
            Console.Write("Enter 1st Integer: ");
            int FirstInteger = int.Parse(Console.ReadLine()); //even user type int, will be a string 
            Console.Write("Enter 2nd Integer: ");
            int SecondInteger = int.Parse(Console.ReadLine()); //even user type int, will be a string 
            Console.WriteLine("The greatest common divisior is: " +
                GCD(FirstInteger, SecondInteger).ToString()); // both sides must be string, but right handside of GCD, so needs to convert to string. 
            Console.ReadKey(); //tell the system to freez. 
        }
    }
}