using System.Collections;

namespace MergeTwoSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            queue.Enqueue("D");
            queue.Enqueue("E");
            //queue.Enqueue("F");
            Tuple<int, string, int, string> tuple = new Tuple<int, string, int, string>(5, "lahari", 7, "varsha");
            var dic = new Dictionary<int, string>();
            dic.Add(tuple.Item1, tuple.Item2);
            dic.Add(tuple.Item3, tuple.Item4);
            
            foreach (var i in dic)
            {
                Console.WriteLine(i.Key);
                Console.WriteLine(i.Value);
            }



        }
    }
}