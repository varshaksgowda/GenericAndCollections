using System;
using System.Collections.Generic;
using System.Text;
namespace Swaping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine("before Swapping");
            foreach(var item in list)
            {
                Console.WriteLine(item); 
            }
            list.Swap(0, 3);
            Console.WriteLine("After Swapping");
            foreach(var items in list)
            {
                Console.WriteLine(items);
            }
        }
    }
    public static class ListExtensions
    {
        public static void Swap<T>(this IList<T> list, int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
    }
}