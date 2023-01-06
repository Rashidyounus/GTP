using System;

namespace Stack
{


    public class Stack
    {

        int max = 10;
        int top;
        int[] stak;
     public Stack()
        {
            stak = new int[max];
            top = -1;
        }

        public void push(int x)
        {
            if (top == (max - 1))
            {
                Console.WriteLine("Stack size limit reached.");
            }
            else
            {
                stak[++top] = x;
                Console.WriteLine(x + " is added into the stack.");
            }
        }
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is Empty");

            }
            else
            {

                int x = stak[top--];
                Console.WriteLine("delete to the stack" + x);
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.push(34);
            s.push(50);

            s.Pop();

            
        }
    }
}
