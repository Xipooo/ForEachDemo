using System;
using System.Collections.Generic;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new List<string> { "Steve", "Joe", "Mary", "Julie" }
            .ForEach(name => Console.WriteLine(name));
            Console.ReadLine();

            new List<string> { "Tom", "Dick", "Harry" }
            .ForEach(n => Console.WriteLine(n));
            Console.ReadLine();
        }
    }
}
