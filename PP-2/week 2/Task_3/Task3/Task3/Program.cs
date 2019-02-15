using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task31
{
    class Program
    {
        public static void Probel(int level) //создаем функцию
        {
            for (int i = 0; i < level; i++)// цикл по показу пробелов
                Console.Write("     ");
        }

        public static void Filewlevel(DirectoryInfo dir, int level)
        {
            foreach (FileInfo f in dir.GetFiles()) //цикл для показа файлов
            {
                Probel(level);//вызываем функцию чтоб разделить файлы пробелом
                Console.WriteLine(f.Name);//показ наименования файла с выбранной директории
            }
            foreach (DirectoryInfo d in dir.GetDirectories()) //цикл для директории 
            {
                Probel(level);//вызываем функцию чтоб разделить файлы пробелом
                Console.WriteLine(d.Name);//показать названия папок
                Filewlevel(d, level + 1);//вызвать первоначальную функцию для другой директории и уровнем
            }
        }


        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("C:/Users/Asus/Desktop/PP2_new/PP-2"); //указываем путь к директрии
            Console.WriteLine(dir.Name);//показать названия папок
            Filewlevel(dir, 0);//вызов функции
            Console.ReadLine();
        }

    }
}