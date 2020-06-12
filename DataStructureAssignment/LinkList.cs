using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAssignment
{
    class LinkList
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
                Console.WriteLine("Split value of Linklist is ");
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

            Console.WriteLine("Split in single parse:");
            Console.WriteLine();
            //myList1.SplitInMiddleSinglePass();
            Console.WriteLine("Split in double parse:");
            Console.WriteLine();

            //myList1.SplitInMiddle();
            Console.WriteLine("Reverse linklist:");
            Console.WriteLine();
            //myList1.Reverse();

        }

    }

    //public class Node
    //{
    //    public Node next;
    //    public Object data;
    //}

    //public class LinkedList
    //{
    //    private Node head;

    //    public void SplitInMiddleSinglePass()
    //    {
    //        Node current = head, currentValue = head;


    //        string[] firstpart = new string[100];
    //        string[] secondpart = new string[100];



    //        int i = 0, j = 0;
    //        while (currentValue != null)
    //        {



    //            if (currentValue != null)
    //            {
    //                if (current != null)
    //                {
    //                    current = current.next;
    //                    if (current != null)
    //                    {
    //                        current = current.next;
    //                    }
    //                    firstpart[i] = Convert.ToString(currentValue.data);

    //                    i++;
    //                }

    //                else
    //                {
    //                    secondpart[j] = Convert.ToString(currentValue.data);
    //                    j++;
    //                }
    //            }

    //            currentValue = currentValue.next;
    //        }

    //        Console.WriteLine("First part of LinkedList");
    //        printNodes(firstpart);
    //        Console.WriteLine("Second part of LinkedList");
    //        printNodes(secondpart);
    //    }


    //    public void SplitInMiddle()
    //    {
    //        Node current = head;


    //        string[] firstpart = new string[100];
    //        string[] secondpart = new string[100];

    //        int count = 0;

    //        while (current != null)
    //        {
    //            ++count;
    //            current = current.next;
    //        }

    //        current = head;

    //        int j = 0, k = 0;

    //        for (int i = 0; i < count; i++)
    //        {

    //            if (current != null)
    //            {
    //                if (i < Math.Ceiling((decimal)((count+1) / 2)))
    //                {
    //                    firstpart[j] = Convert.ToString(current.data);
    //                    j++;
    //                }
    //                else
    //                {
    //                    secondpart[k] = Convert.ToString(current.data);
    //                    k++;
    //                }
    //                current = current.next;
    //            }
    //        }

    //        Console.WriteLine("First part of LinkedList");
    //        printNodes(firstpart);
    //        Console.WriteLine("Second part of LinkedList");
    //        printNodes(secondpart);
    //    }


    //    public void Reverse()
    //    {
    //        Node current = head, currentValue = null;


    //        string[] firstpart = new string[100];
    //        string[] secondpart = new string[100];

    //        while (current != null)
    //        {
    //            Node tmp = current.next;
    //            current.next = currentValue;
    //            currentValue = current;
    //            current = tmp;
    //        }

    //        current = currentValue;
    //        int i = 0;
    //        while (current != null)
    //        {
    //            if (current != null)
    //            {
    //                current = current.next;
    //                firstpart[i] = Convert.ToString(currentValue.data);
    //                i++;
    //            }
    //            currentValue = currentValue.next;
    //        }

    //        Console.WriteLine("Reverse of LinkedList");
    //        printNodes(firstpart);

    //    }



    //    public void printNodes(string[] nodes)
    //    {

    //        Console.WriteLine();
    //        for (int z = 0; z < nodes.Count(); z++)
    //        {
    //            if (nodes[z] == "" || nodes[z] == null)
    //                break;
    //            if (z > 0)
    //            {
    //                Console.Write(", " + nodes[z]);

    //            }
    //            else
    //                Console.Write(nodes[z]);
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine();

    //    }

    //    public void Add(Object data)
    //    {
    //        Node toAdd = new Node();

    //        toAdd.data = data;
    //        toAdd.next = head;

    //        head = toAdd;
    //    }


    //}
}