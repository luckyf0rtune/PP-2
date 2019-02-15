using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student //Создаём класс Student
    {
        public string name;
        public string id;
        public int year;

        public Student(string name, string id, int year)
        {
            this.name = name; // Назначаем классу Student имени введённого пользователем
            this.id = id; // Назначаем классу Student id введённого пользователем
            this.year = year; // Назначаем классу Student year введённого пользователем
        }
        public void print()
        {
            Console.WriteLine("Student Name: {0}", name); //Вывод имени студента
            Console.WriteLine("Student ID: {0}", id); //Вывод id студента
            if (year == 4) // Условие для проверки года обучения 
            {
                Console.WriteLine("You are graduate.");//Вывод в консоль, что вы выпускник

            }
            else
            {
                year++;
                Console.WriteLine("Next year is :{0}", year); //Вывод курса, на котором учится студент
            }
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name, id and year"); //Вывод вопроса к пользователю
            Student str1 = new Student(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));//Ввод данных
            str1.print();//Вывод данных
            Console.ReadLine(); //Команда для того, чтобы консоль не закрывалась после завершения работы
        }
    }
}
