using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Cell
    {
        public string Value;
        public Cell Next;
        public Cell Prev;

        public void enqueue(Cell TopSentinel, string data)
        {
            
                Cell cell = new Cell(); //instantiate cell
                cell.Value = data; //initialize the data in the cell
                cell.Next = TopSentinel.Next; //Insert the new cell as first
                cell.Next.Prev = cell; //(cell.Next).Prev = cell;
                cell.Prev = TopSentinel;
                TopSentinel.Next = cell; //TopSentinel points at the new first cell
            }
        public void dequeue(Cell TopSentinel, string data)
        {
            Cell.Value = data;

        }
    }
}
