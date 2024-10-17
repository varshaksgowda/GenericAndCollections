//using System;
//using System.Collections.Generic;
//namespace LinkedList
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            LinkedList<int> linkedlist = new LinkedList<int>();
//            linkedlist.AddFirst(8);
//            linkedlist.AddBefore(linkedlist.First, 9);
//            linkedlist.AddAfter(linkedlist.First, 10);
//            linkedlist.AddLast(5);
//            foreach(var i in linkedlist)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
namespace GenericQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Generic<int> queue = new Generic<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("Elements in queue");
            queue.Display();
            Console.WriteLine("Dequeue");
            queue.Dequeue();
            Console.WriteLine("Count");
            var co = queue.count();
            Console.WriteLine(co);

        }
    }
    public class Generic<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        public void Enqueue(T item)
        {
            list.AddLast(item);
        }
        public void Display()
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        public void Dequeue()
        {
            var v = list.First.Value;
            Console.WriteLine(v);
            list.RemoveFirst();
        }
        public int count()
        {
            return list.Count;
        }

    }
}