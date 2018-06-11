using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, it's my first code in C#");
            Console.ReadLine();
            Console.Write("and here's more text following the command");
            Console.ReadLine();
            Console.Write("Click enter twice to close the app");
            Console.ReadLine();
            Employee employee = new ConsoleApplication1.Employee("Adam", 23, "D");
            Console.WriteLine(employee.DisplayDetails());
            Console.WriteLine(employee.Name = "John");
            Console.WriteLine(employee.DisplayDetails());
            Console.WriteLine(employee.Name = "John4");
            Console.ReadLine();
        }
    }
}
