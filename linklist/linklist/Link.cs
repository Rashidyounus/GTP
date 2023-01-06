using System;
using System.Collections.Generic;
using System.Text;

namespace linklist
{
    class Link
    {
        Node head;


        public Link()
        {
            head = null;
        }

        public void insert(int value)
        {


            Node newNode = new Node();
            newNode.data = value;
            newNode.next = head;
            head = newNode;
        }

        public void delete()
        {
            if (head != null)
            {

                Node temp = new Node();
                head = head.next;
                temp = null;
            }
            
        }

        public void Search(int value )
        {

            Node temp = new Node();
            temp = head;

            int found = 0;
            int i = 0;

            if (temp != null)
            { 
               
                while (temp!=null)
                {
                    i++;
                    if (temp.data == value)
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;
                }
                if (found == 1)
                {
                    Console.WriteLine(value + "Value is found" + i);

                }
                else
                {
                    Console.WriteLine(value + "value is not found");
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
            

        }
        public void dispaly()
        {
            Node temp = new Node();
            temp = this.head;
            if (temp!=null){

                Console.WriteLine("list is contains");
                while (temp != null)
                {
                    Console.WriteLine("" + temp.data);
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }

    }

  
}
