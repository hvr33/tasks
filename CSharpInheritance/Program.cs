
using ConsoleApp1;
using System;
namespace consoleAPP1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new SalesMan(1, "asmaa", 200, 100, 2);
            Console.WriteLine(employee);
            employee.Print();
            Console.WriteLine("\n////////////////");
            Employee employee1 = new ACounter(2,"ahmed",200, 100, 2);
          employee1.Print();
            SalesMan salesmain =new SalesMan(3,"mohmed",300,100, 2);
            Console.WriteLine("\n////////////////");
            Console.WriteLine(salesmain);
            salesmain.Print();
            Console.WriteLine("\n////////////////");
            ACounter aCounter = new ACounter(4,"mostafa",100,3,1);
            aCounter.Print();
            Console.WriteLine("\n////////////////");




        }
    }
}



