using System;
using System.IO;

namespace UsingLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string usernum = Convert.ToString(Console.ReadLine());
            File.WriteAllText(@"C:\Users\tristan.hillyard\Logs\logs.text", usernum);
            Console.WriteLine(File.ReadAllText(@"C:\Users\tristan.hillyard\Logs\logs.text"));
        }
    }
}
