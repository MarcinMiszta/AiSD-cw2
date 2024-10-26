using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_cwiczenia_2
{
    internal class List
    {
        public NodeL head;
        public NodeL tail;
        public int count=0;

        public void AddFirst(int liczba)
        {
            
        }
        public void AddLast(int liczba) 
        {
            var tmp = new NodeL(7);
            tmp.p = this.tail.p;
            this.tail.n = tmp;
            this.count++;
            this.tail=tmp;
        }

        public List(int liczba)
        {
            this.count = liczba;
        }
    }
}
