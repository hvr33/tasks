using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        public int id;
        public string name;
        public double salary;
        public virtual double Getsalary() { return salary; }

        public Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;

        }
        public virtual void Print()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Salary: {Getsalary()}");



        }


    }
    class ACounter : Employee
    {
        public double prjectacount;
        public double horecount;
 public ACounter (int id, string name, double salary, double prjectacount, double horecount):base(id,name,salary)
        {
            this.prjectacount= prjectacount;
            this.horecount= horecount;
        }
        public override double Getsalary()
        {
            double resul = salary + (prjectacount * horecount);
            return resul;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"projectacount: {prjectacount},horecount: {horecount}");


        }
    }

    class SalesMan : Employee
    {
        public double comission;
        public int projectcount;

        public SalesMan(int id, string name, double salary ,double comission, int projectcount):base(id,name,salary) 
        {
            this.comission = comission;
            this.projectcount = projectcount;
        }

        public override double Getsalary()
        {
            comission = projectcount * 200;
            return salary + comission;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"projects: {projectcount}");
            Console.WriteLine($" comission: {projectcount * 200}");

        }


    }
}

