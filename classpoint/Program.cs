using System;

using classpoint.Models;


class Program
{
    static void Main(string[] args)
    { 


       Point p1 = new Point(2, 3);
         Point p2 = new Point(4, 5);
    Point sum = p1 + p2;
     Point difference=p1 - p2;
        Point product=p1 * p2;
        Point  quotient=p1 / p2;
        
        

        Console.WriteLine($"p1: {p1}");
          Console.WriteLine($"p2: {p2}");
          Console.WriteLine($"Sum: {sum}");
          Console.WriteLine($"Difference: {difference}");
          Console.WriteLine($"Product: {product}");
          Console.WriteLine($"Quotient: {quotient}");
        Console.WriteLine($"p1.Equals(p2)? {p1.Equals(p2)}");   

        Console.WriteLine($"p1 HashCode: {p1.GetHashCode()}");
        Console.WriteLine($"p2 HashCode: {p2.GetHashCode()}");
    }
}

