using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Singleton Patterns";
            var obj1 =  Single.GetInstance();
            var obj2 = Single.GetInstance();

            if(obj1.Equals(obj2))
            {
                Console.WriteLine("Same objects");
            }
            else
            {
                Console.WriteLine("Different objects");
            }
        }
    }
}
