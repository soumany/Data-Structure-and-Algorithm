using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
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

            Cell cell = new Cell();
            cell.Value = data;
            cell.Next = TopSentinel.Next;
            cell.Next.Prev = cell;
            cell.Prev = TopSentinel;
            TopSentinel.Next = cell;
        }
      
        public void dequeue(Cell TopSentinel)
        {
            if (this.Prev != TopSentinel) //this refer to what we call in the program.cs
            {
                this.Prev.Prev.Next = this;
                this.Prev = this.Prev.Prev;
            }
        }

    }
}

