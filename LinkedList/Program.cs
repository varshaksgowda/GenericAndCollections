using System;
using System.Collections.Generic;
namespace GenericStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> linkedlist = new LinkedList<int>(); 
            linkedlist.AddFirst(7);
            linkedlist.AddFirst(9);

            linkedlist.AddAfter(linkedlist.First, 9);
            linkedlist.AddBefore(linkedlist.First, 8);
            linkedlist.AddAfter(linkedlist.Last, 4);
            linkedlist.AddLast(8);
            LinkedList<int> Names = new LinkedList<int>();
            Names.AddFirst(1);
            Names.AddAfter(Names.First, 2);
            Names.AddBefore(Names.First, 3);
            LinkedList<int> Final = new LinkedList<int>();
            foreach (int i in linkedlist)
            {
                Final.AddFirst(i);
            }
            foreach (int j in Names)
            {
                Final.AddAfter(Final.First, j);
            }
            var sort = Final.Order();
            foreach (int sorted in sort)
            {
                Console.WriteLine(sorted);
            }
            for (int i = 0; i < Final.Count; i++)
            {
                for (int j = i + 1; j < Final.Count; j++)
                {
                    if (Final.ElementAt<int>(i) == Final.ElementAt<int>(j))
                    {
                        Final.Remove(Final.ElementAt<int>(j));
                        j--;

                    }
                }
            }
            foreach (int result in Final)
            {
                Console.WriteLine(result);
            }




            var reverse = linkedlist.Reverse();
            int count = linkedlist.Count;
            int count1 = count / 2;
            if (count % 2 == 0)
            {

                //int firstnumber = count / 2;
                for (int i = count / 2 - 1; i <= count / 2; i++)
                {
                    Console.WriteLine(linkedlist.ElementAt<int>(i));

                }
            }
            else
            {
                Console.WriteLine(linkedlist.ElementAt<int>(count1));
            }



            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
            foreach (var items in reverse)
            {
                Console.WriteLine(items);
            }

            List<int> L1 = new List<int>();
            L1.Add(1);
            L1.Add(2);
            L1.Add(3);
            L1.Add(4);
            L1.Add(2);
            L1.Add(3);
            for (int i = 0; i < L1.Count; i++)
            {
                for (int j = i + 1; j < L1.Count; j++)
                {
                    if (L1[i] == L1[j])
                    {
                        L1.RemoveAt(j);

                        j--;
                    }
                }
            }
            foreach (int i in L1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
