using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAssignment
{
    class LoopPointLinklist
    {
        //static void Main(string[] args)
        //{
        //    ProcessLinkList();

        //}
        static void ProcessLinkList()
        {
            Console.WriteLine("Enter Range of LinkList:");

            Console.WriteLine("Enter Start Value:");
            uint firstNumber = 0;
            uint.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter End Value:");
            uint secondNumber = 0;
            uint.TryParse(Console.ReadLine(), out secondNumber);

            if (firstNumber > 0 && secondNumber > 0 && firstNumber < secondNumber)
            {
                Console.WriteLine("Loop point of Linklist is ");
                Console.WriteLine();
                BindList(firstNumber, secondNumber);

            }
            else
            {
                Console.WriteLine("Number you have entered is not valid.");
                Console.ReadKey();
                Console.Clear();
                ProcessLinkList();
            }
            Console.WriteLine("Press key to restart.");
            Console.ReadKey();
            Console.Clear();
            ProcessLinkList();
        }
        static void BindList(uint first, uint second)
        {
            LinkedList myList1 = new LinkedList();

            for (uint i = second; i >= first; i--)
            {
                myList1.Add(i);
            }


            Console.Write(myList1.hasLoop());

        }
    }


    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        private Node head;

        public bool hasLoop()
        {
            Node current = head, currentValue = head;

            bool hasLoop = false;


            while (current != null)
            {
                current = current.next;
                if (current != null)
                {
                    current = current.next;
                }
                currentValue = currentValue.next;
                if (current == currentValue)
                {
                    hasLoop = true;
                    break;
                }
            }

            return hasLoop;
        }


        public void Add(Object data)
        {
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }


    }
}
