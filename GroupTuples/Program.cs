using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
namespace Tuples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = new[]
            {
                Tuple.Create(1,"lahari"),
                Tuple.Create(2,"lalitha"),
                Tuple.Create(2,"Priya"),
                Tuple.Create(5,"monika"),
                Tuple.Create(5,"Kavya"),
                Tuple.Create(6,"sravya")
            };
            var number1 = number.GroupBy(n => n.Item1);
            foreach (var item in number1)
            {
                Console.WriteLine("Key" + item.Key);
                foreach (var items in item)
                {
                    Console.WriteLine($"{items.Item1} {items.Item2} ");
                }
            }
            //Tuple<int, int, string> tuple1 = new Tuple<int, int, string>(6, 8, "lalitha");
            //{
            //    tuple1.Item1
            //}
        }
    }
}
