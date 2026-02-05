using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppsreuct2.Models
{
 public  struct Student
    {
       
             
           private int id;
           private string name;
        private double grad;
       private bool passed;

        public double Grad {
            get { return grad; }
            set
            {
                if (value>=0&&value<=100)
                {
                    grad = value;
                }
                else {
                    Console.WriteLine("Invalid grade. Please enter a value between 0 and 100.");
                }
            }
        
        
        }

        public bool Passed
        {
           

            get { return Grad >= 50;

            }

        }
      public Student(int id,string name,double grad)
        {
            this.id = id;
            this.name = name;
            this.grad = 0;
            Grad = grad;

        }

       
      
        public int GetGradeAsInt()
        {
          return (int)grad  ;
        }
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Grade: {GetGradeAsInt()}, Passed: {Passed}";
        }
    }
}
