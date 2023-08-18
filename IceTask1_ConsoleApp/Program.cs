using System.Xml.Linq;

namespace IceTask1_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList li = new LinkedList();
            Node node = new Node();
            AddStory();
            PrintAll(AddStory().head);

            li.head = node.mergeSort(AddStory().head);
            Console.WriteLine("Sorted List");
            printSortedList(li.head);
        }

        static LinkedList AddStory()
        {
            LinkedList story = new LinkedList();
            AddFirst(story, 3 ,"With every line of code mastered, Alex gains experience points, levelling up and unlocking new abilities like Debugging Dash and Algorithmic Aura.");
            AddLast(story,  12,"The tale of Alex, the IT student-turned-digital-legend, is forever etched in the annals of Cybersphere, inspiring aspiring programmers to pursue their dreams.");
            AddLast(story,  4,"The Firewall Fortress looms ahead, its defences formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks.");
            AddLast(story, 2,"Armed with a trusty keyboard and a digital sword, Alex enters the Coding Caverns, where bugs and glitches guard the treasures of programming wisdom.");
            AddLast(story, 1,"In the virtual realm of Cybersphere, our hero, Alex, a determined IT student, embarks on an epic quest for knowledge.");
            AddLast(story, 7,"Along the journey, Alex forges alliances with NPC coders, forming a guild known as \"Syntax Sentinels,\" united by their dedication to digital mastery.");
            AddLast(story,10, "Victory is hard-won, but Alex's leadership and IT prowess lead to the defeat of the Malware Marauders, restoring peace to Cybersphere.");
            AddLast(story, 11,"Celebrated as a digital hero, Alex stands at the forefront of innovation, using the knowledge gained to create groundbreaking applications that shape the future of technology.");
            AddLast(story, 9,"In a climactic battle, Alex and the Syntax Sentinels engage in a virtual war, using complex algorithms and strategic thinking to outwit the Malware Marauders' schemes.");
            AddLast(story, 5,"Inside the fortress, a virtual reality riddle awaits – a puzzle that can only be solved by applying principles of encryption and decryption learned during countless late-night study sessions.");
            AddLast(story, 6,"Emerging victorious, Alex discovers the hidden Repository of the Ancients, a collection of long-lost IT texts rumoured to contain the ultimate programming language.");
            AddLast(story, 8,"The guild faces its nemesis in the form of the Malware Marauders, a rival group aiming to spread chaos and disrupt the digital realm.");
           return story;
            
        }

        static void AddFirst(LinkedList doubleLinkedList,int id , string data)
        {

            Node newNode = new Node( id,data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;

            }

            doubleLinkedList.head = newNode;


        }

        static void AddLast(LinkedList doubleLinkedList,int id ,string data)
        {
            Node newNode = new Node(id, data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            Node lastNode = GetLast(doubleLinkedList.head);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        public static void PrintAll(Node Head)
        {
            Node current = GetFirst(Head);

            Console.WriteLine("Printing out whole list");
            while (current != null)
            {
                Console.WriteLine(current.id + ":" + current.text);
                current = current.next;
            }
        }

        public static Node GetFirst(Node Middle)
        {
            Node first = Middle;
            while (first.prev != null)
            {
                first = first.prev;
            }

            return first;
        }
       
        public static Node GetLast(Node Head)
        {
            Node last = Head;
            while (last.next != null)
            {
                last = last.next;
            }

            return last;
        }

        public static void printSortedList(Node Head)
        {
            while (Head != null)
            {
                Console.WriteLine(Head.id + ":" + Head.text);
                Head = Head.next;
            }
        }
    }

    //https://www.geeksforgeeks.org/merge-sort-for-linked-list/
}