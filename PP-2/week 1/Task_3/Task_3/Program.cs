using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Вводим размер массива n
            string[] str = Console.ReadLine().Split();//Ввод чисел с помощью строки и разделяем с помощью пробела
            int[] array = new int[n]; // Задаём название массива и присваиваем ему размер n
            for(int i = 0; i < array.Length; i++) //Преобразование строчного массива в числовой
            {
                array[i] = int.Parse(str[i]);//Приравниваем введенные значения в формат int
            }

            for(int i = 0; i < array.Length; i++)//Вывод уже продублированных готовых чисел 
            {
                Console.Write("{0} {0} ",array[i]);//Вывод чисел в консоль
            }
            Console.ReadLine();//Команда, чтобы консоль не закрывалась
        }
    }
}
