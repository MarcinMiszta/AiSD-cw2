using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_cwiczenia_2
{
    internal class NodeL
    {
        public NodeL n;
        public NodeL p;
        public int data = 3;

        public NodeL(int liczba)
        {
            this.data = liczba;
        }
    }
}
