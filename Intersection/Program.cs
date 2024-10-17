using System;
using System.Collections.Generic;
using System.Linq;
namespace Intersection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(7);
            list2.Add(8);
            list2.Add(3);
            var intersections = list1.Intersect(list2);
            foreach (var intersect in intersections)
            {
                Console.Write(intersect + " ");
            }
            
        }
    }
}