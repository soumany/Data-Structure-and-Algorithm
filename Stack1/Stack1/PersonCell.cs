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
        { //tp insert a newCell as the first node
            PersonCell newCell = new PersonCell();
            newCell.Name = newName;
            newCell.Next = this.Next;//this.Next will become 2nd cell
            this.Next = newCell; //make this.Next point to newCell

        }
        
        public void pop(PersonCell TopCell)
        {//assign the address in the next property of the first cell to the next property of the top cell. 
            PersonCell FirstCell = TopCell.Next; //FirstCell is given the address of TopCel.Next that is the address of the first cell of the linked list
            TopCell.Next = FirstCell.Next;

        }

        public void peek(PersonCell TopCell)
        {
            Console.WriteLine("Top Cell is : " + TopCell.Next.Name);
        }
    }

}
