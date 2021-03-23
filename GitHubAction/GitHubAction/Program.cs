using System;

namespace GitHubAction
{
    class Program
    {
        static void Main(string[] args)
        {   


            foreach(var arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine("Hello World2!");
           
        }
    }
}
