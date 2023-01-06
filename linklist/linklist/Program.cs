using System;

namespace linklist
{
    class Program
    {
        static void Main(string[] args)
        {

            Link list = new Link();
            list.insert(34);
            list.insert(54);
            list.insert(67);
            list.Search(67);

            list.dispaly();



        }
    }






}
