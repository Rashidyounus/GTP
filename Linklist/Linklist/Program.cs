using System;

namespace Linklist
{


    public class Node
    {
     public  Node next;
       public int data;
    }


     public class linklist
    {
      public  Node head;

        public linklist()
        {
             head=null;

        }

        public void add(int value)
        {
            Node n1 = new Node();
            n1.data = value;
            n1.next = head;
            head = n1;
            Console.WriteLine("Head" + value);



        }



        public void addlast(int newvalue)
        {
            // allocate node
            Node newNode = new Node();
            // assign data element
            newNode.data = newvalue;
            // assign null to the next of new Node
            newNode.next = null;

            // check list is empty or note
            // if empty make a new node as head
            if (head == null)
            {
                head = newNode;
            }
            else
            {

             //   Else, traverse to the last node
                Node temp = new Node();
                temp = head;
                while (temp.next != null)
                    temp = temp.next;
               // Change the next of last node to new node
                temp.next = newNode;
            }
        }

        public void print()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    Console.WriteLine(""+temp.data);
                    temp = temp.next;
                }
              //  Console.WriteLine();
            }
            else
            {
                Console.WriteLine("list is empty");
            }

            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            linklist list = new linklist();

            //list.addlast(100);
            //// first Node
            //Node first = new Node();
            //first.data = 10;
            //first.next = null;

            //// link the head Node
            //list.head = first;

            //// add second Node
            //Node second = new Node();
            //second.data = 20;
            //second.next = null;

            //// link the first Node
            //first.next = second;
            //   list.add(30);
            //  list.add(40);

            //list.add(12);
            list.addlast(1);
            list.addlast(2);
            list.add(5);
            list.addlast(6);
            list.print();

        

            Console.ReadLine();
        }
    }
}
