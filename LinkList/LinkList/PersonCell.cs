using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkListCLI
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

        public void InsertAfter(string newName)
        { //tp insert a newCell as the first node
            PersonCell newCell = new PersonCell();
            newCell.Name = newName;
            newCell.Next = this.Next;
            this.Next = newCell; //make this.Next point to newCell

        }
        public PersonCell FindCell(string name)
        {
            for (PersonCell cell = this; ; cell = cell.Next) 
            {
                if (cell == null) return null;
                if (cell.Name == name) return cell;
            }
        }
        public void InsertAfter(string afterName, string newName)
        {
            PersonCell afterCell = FindCell(afterName);
            if (afterCell == null)
            {
                throw new KeyNotFoundException("Item" + afterName + "not found in list");
            }
            //Insert a new cell with the new name after the one we found
            afterCell.InsertAfter(newName);

        }
        public void RemoveFirst()
        {//assign the address in the next property of the first cell to the next property of the top cell. 

        }
    }

}
