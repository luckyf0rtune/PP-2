using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Asus\Desktop\input.txt"); //Считываем строки файла, путь которого мы указываем
            string[] arr = text.Split(); //Разбиваем строку по символам пробелом
            int n = arr.Length; //Создаём массив с размером n 
            string output = ""; //Создаём строку со значением ""
            int[] a = new int[n];// Создаём массив с размером n
            bool prime = false; //переменная prime со значением false
            Console.WriteLine(n); //Выводит в консоль количество символов в массиве
            for (int i = 0; i < n; i++) // пробегаемся по всем числам в массиве
            {
                a[i] = int.Parse(arr[i]); // конвертируем строковое значение числа в цифровое
                for (int j = 2; j < a[i] / 2; j++) // делим число на аргументы, проверяющие это число
                {
                    if (a[i] % j == 0)//проверяем простое ли число
                    {
                        prime = true;
                        break;
                    }
                }
                if (prime == false)
                {
                    output = output + a[i] + " ";
                }
                prime = false;
            }
            System.IO.File.WriteAllText(@"C:\Users\Asus\Desktop\output.txt", output);//заносим простые числа, выведенные с помощью программы

        }
    }
}
