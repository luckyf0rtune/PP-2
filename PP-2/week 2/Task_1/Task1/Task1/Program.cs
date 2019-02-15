using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            bool palindrome = false;//Создаём переменную palindrome которая будет проверяться 
            string text = System.IO.File.ReadAllText(@"C:\Users\Asus\Desktop\1text.txt");//Метод, который читает текст в файле, который мы указываем, далее указываем путь к файлу, с которого будет считываться строка
            for (int i = 0, j = text.Length - 1; i < text.Length / 2; i++, j--)//текст делится на половину, и проверяет каждый следующий символ
            {
                if (text[i] != text[j]) // Условие, если символ левой стороный не равен символу правой стороне поделенного текста
                {
                    palindrome = true;
                    break;
                }
                if (palindrome == true)
                {
                    Console.WriteLine("No"); // В консоль выводится "No"
                }
                else
                {
                    Console.WriteLine("Yes"); //В консоль выводится "Yes"
                }
                Console.ReadLine(); //Команда, которая не дает консоли закрыться, после выполнения программы
            }
        }
    }
}

