using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    internal class PersonCell
    {
        public string Name;
        public PersonCell Next; //Next contain address of a personcell obj

        public PersonCell() { } //empty constructor or default constructor

        public PersonCell(string name, PersonCell next) //a contructor that takes in two argument and it initialize an object
        {
            Name = name;
            Next = next;
        }

        public void push(string newName)
        {
            PersonCell newCell = new PersonCell();
            newCell.Name = newName;
            newCell.Next = this.Next;
            this.Next = newCell;
        }
        
        public void pop(PersonCell TopCell)
        {//assign the address in the next property of the first cell to the next property of the top cell. 
            PersonCell FirstCell = TopCell.Next;
            TopCell.Next = FirstCell.Next;

        }

        public void peek(PersonCell TopCell)
        {
            if (TopCell.Next == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Top Cell is : " + TopCell.Next.Name);
            }
        }

        
    }

}
