using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Ввод число n, которое покажет количество рядов и столбцов в последнем ряду
            for(int i = 0; i < n; i++)//Цикл, который соединяет один ряд со следующим
            {
                for (int j = 0; j <= i ; j++)//Цикл, увеличивающий длину ряда
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
            Console.ReadLine();//Команда, чтобы консоль не закрывалась после завершения работы
        }
    }
}
