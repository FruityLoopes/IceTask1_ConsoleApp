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


        public Node()
        {
           

        }
        public Node(int id, string text)
        {
            this.text = text;
            this.id = id;
            prev = null;
            next = null;

        }

        public Node sortedMerge(Node a, Node b)
        {
            Node result = null;
            /* Base cases */
            if (a == null)
                return b;
            if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.id <= b.id)
            {
                result = a;
                result.next = sortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = sortedMerge(a, b.next);
            }
            return result;
        }

        public Node mergeSort(Node h)
        {
            // Base case : if head is null
            if (h == null || h.next == null)
            {
                return h;
            }

            // get the middle of the list
            Node middle = getMiddle(h);
            Node nextofmiddle = middle.next;

            // set the next of middle node to null
            middle.next = null;

            // Apply mergeSort on left list
           Node left = mergeSort(h);

            // Apply mergeSort on right list
            Node right = mergeSort(nextofmiddle);

            // Merge the left and right lists
            Node sortedlist = sortedMerge(left, right);
            return sortedlist;
        }

        public Node getMiddle(Node h)
        {
            // Base case
            if (h == null)
                return h;
            Node fastptr = h.next;
            Node slowptr = h;

            // Move fastptr by two and slow ptr by one
            // Finally slowptr will point to middle node
            while (fastptr != null)
            {
                fastptr = fastptr.next;
                if (fastptr != null)
                {
                    slowptr = slowptr.next;
                    fastptr = fastptr.next;
                }
            }
            return slowptr;
        }
    }
}
