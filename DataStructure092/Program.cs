using System;

namespace DataStructure092
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Add(80);

            //list.InsertAtParticularPosition(2,30);
            list.Display();
            Console.ReadKey();
        }
    }
}
