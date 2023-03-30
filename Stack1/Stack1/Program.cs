using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonCell TopCell = new PersonCell("<sentinel>", null);

            int x = 0;
            while (x != 5)
            {
                Console.Clear();
                Console.WriteLine("Enter 0 to display the stack.");
                Console.WriteLine("Enter 1 to push a string to the stack.");
                Console.WriteLine("Enter 2 to pop a string from the stack.");
                Console.WriteLine("Enter 3 to peek what is at the top of the stack");
                Console.WriteLine(":");
                Console.WriteLine("Enter any other number to exit.\n\n");
                

                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Display the stack:");
                    for (PersonCell cell = TopCell; cell != null; cell = cell.Next)
                    {
                        Console.WriteLine(cell.Name);
                    }
                }
                else if (x == 1)
                {
                    Console.Write("Enter a name of the string to be pushed onto the stack: ");
                    string NewName = Console.ReadLine();

                    TopCell.push(NewName);//here after means after the topcell (head)
                }
                else if (x == 2)
                {
                    TopCell.pop(TopCell);

                 


                }
                else if (x == 3)
                {

                    TopCell.peek(TopCell);

                }
                else if (x == 4)
                {


                }
                else if (x == 5)
                {

                }
                else break;
                Console.WriteLine("Press space bar to continue.");
                Console.ReadKey();
            }
            
            //Console.ReadKey();
        }
    }
    
}
