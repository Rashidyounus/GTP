using System;

namespace Queuelist
{
    class Program
    {

       private int max = 10;
        private int front;
        private int rear;
        private int[] queue;

        public Program()
        {
            queue = new int[max];
            front = -1;
            rear = -1;
        }


       

       public void Isempty()
        {
            if (rear == front)
            {
                Console.WriteLine("Queue is empty");

            }
            else
            {
                Console.WriteLine("Queue is not Empty");
            }
        }


        public void Insert(int val)
        {
            if (rear==(max - 1))
            {
                Console.WriteLine("");
            }
            else
            {
                queue[++rear] = val;
                Console.WriteLine(val+ " add the element into the Queue");
            }
        }

     public void delete()
        {
            if (rear == front)
            {
                Console.WriteLine("list is Empty");
            }
            else
            {
               int x= queue[++front];
                Console.WriteLine(x + "value Delete the Queue");
                
            }
         


        }
      

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program lis = new Program();
            lis.Insert(23);
            lis.Insert(45);
           
            lis.delete();
            Console.ReadLine();



        }
    }
}
