using System;

namespace EnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers : ");
            var even = new Even();
            foreach (var evnnum in even)
            {
                if ((int)evnnum > 50)
                    continue;
                Console.WriteLine(evnnum);
            }
        }
    }
}
