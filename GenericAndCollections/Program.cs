using System;
using System.Collections;
using System.Collections.Generic;
namespace GenericStack
{
    public class Program
    {
        public static void Main(string[] args)
        {
         //   DataCollections<Student> collections = new DataCollections<Student>();
         //   collections.Add(new Student { Id = 4, Nmae = "Lahari" });
         //   collections.Add(new Student
         //   {
         //       Id = 9,
         //       Name = "lalitha});
   
         //collections.Add(new Student
         //{
         //    Id = 7,
         //    Name = "kalayani});
   
         //collections.Add(new Student { Id = 6, Name = "bhavya" });
             Stack<int> stack = new Stack<int>();
             stack.Push(1);
             stack.Push(2);

         foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
         Stack<Student> stack1=new Stack<Student>();
            stack1.Push(new Student { Id = 1, Name = "varsha" });
            stack1.Push(new Student { Id = 3, Name = "lahari" });
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                //int id=
            }
            foreach(var item in stack1)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
            }
        }
    }
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
    }
}
