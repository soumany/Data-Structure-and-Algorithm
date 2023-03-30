using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkListCLI
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
                Console.WriteLine("Enter 0 to display the linked list.");
                Console.WriteLine("Enter 1 to insert a node as first node.");
                Console.WriteLine("Enter 2 to insert a node after a known node.");
                Console.WriteLine("Enter 3 to insert a node as the last node.");
                Console.WriteLine("Enter 4 to search for a piece of data.");
                Console.WriteLine("Enter 5 to delete a node of a given name.");
                Console.WriteLine(":");
                Console.WriteLine("Enter any other number to exit.\n\n");

                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("Display the singly Linked list is:");
                    for (PersonCell cell = TopCell; cell != null; cell = cell.Next)
                    {
                        Console.WriteLine(cell.Name);
                    }
                }
                else if (x == 1)
                {
                    Console.Write("Enter a name of the new node: ");
                    string NewName = Console.ReadLine();

                    TopCell.InsertAfter(NewName);
                }
                else if (x == 2)
                {

                    Console.Write("Enter a name of the new node: ");
                    string NewName = Console.ReadLine();
                    Console.Write("Enter name of node to insert after it: ");
                    string AfterName = Console.ReadLine();
                    TopCell.InsertAfter(AfterName, NewName);


                }
                else if (x == 3)
                {
                    Console.Write("Enter a name of the new node: ");
                    string NewName = Console.ReadLine();
                   // TopCell.InsertLast(NewName);


                }
                else if (x == 4)
                {
                    Console.Write("Enter the string you want to find:");
                    string something = Console.ReadLine();
                    TopCell.FindCell(something);

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
