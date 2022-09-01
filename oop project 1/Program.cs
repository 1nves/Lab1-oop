using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_project_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string first, second;

            Console.Write("Enter first word= ");
            first = Console.ReadLine();
            Console.Write("Enter second word= ");
            second = Console.ReadLine();

            first = new string(first.Distinct().ToArray());
            List<String> list2 = new List<string>();
            for (int i = 0; i < second.Length; i++)
            {
                list2.Add(second[i].ToString());
            }

            for (int i = 0; i < first.Length; i++)
            {
                Console.WriteLine(first[i].ToString() + " = " + list2.Exists(symbol => symbol.ToString() == first[i].ToString()));
            }
            Console.WriteLine(" Hello world");
            Console.WriteLine(" Hello world 2");
            Console.ReadLine();
        }
    }
}
