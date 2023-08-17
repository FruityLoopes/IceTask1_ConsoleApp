using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask1_ConsoleApp
{
    public class Node
    {
        public String text;
        public int id;
        public Node next;
        public Node prev;

        public Node(int id, string text)
        {
            this.text = text;
            this.id = id;
            prev = null;
            next = null;

        }
    }
}
