using ConsoleAppsreuct2.Models;
using System;   
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace ConsoleAppsreuct2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int size = int.Parse(Console.ReadLine());
            Student[] students = new Student[size];
           Student student=new Student();
          
            for (int i = 0; i < size; i++)
            {
                 Console.WriteLine($"\nStudent: {i + 1}");
                Console.WriteLine("Enter Student ID");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name");
                string name = Console.ReadLine();
                Console.WriteLine("ENte Stutend grad");
                int grad = int.Parse(Console.ReadLine());
                students[i]=new Student(id,name,grad);
               
         
               
               

            };
            display(students);
        }
      static public void display(Student[] students)
        {
            double totalGrades = 0;
            int passedCount = 0;
            int failedCount = 0;

            Console.WriteLine("\n--- Students Data ---");
            foreach (Student s in students)
            {
                Console.WriteLine(s); // ToString()
                totalGrades += s.Grad;

                if (s.Passed)
                    passedCount++;
                else
                    failedCount++;
            }

            double average = totalGrades / students.Length;

            Console.WriteLine("\n--- Statistics ---");
            Console.WriteLine($"Average Grade: {average}");
            Console.WriteLine($"Passed Students: {passedCount}");
            Console.WriteLine($"Failed Students: {failedCount}");
        }
    }



}

    
    










    



    
