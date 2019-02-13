using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public int year;

        public Student(string name, string id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public void print()
        {
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine("Student ID: {0}", id);
            if (year == 4)
            {
                Console.WriteLine("You are graduate.");

            }
            else
            {
                year++;
                Console.WriteLine("Next year is :{0}", year);
            }
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name, id and year");
            Student str1 = new Student(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            str1.print();
            Console.ReadLine();
        }
    }
}
