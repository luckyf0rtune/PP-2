using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Asus\Desktop\path";//Указываем путь на первую директорию
            string path1 = @"C:\Users\Asus\Desktop\path1";//Указываем путь на вторую директорию
            Directory.CreateDirectory(path);//Создаём первую директорию 
            Directory.CreateDirectory(path1);//Создаём вторую директорию
            string file = "test.txt";//Задаём имя файлу
            File.Create(path + @"\" + file).Dispose();//Создание пустого файла в директории path
            string com = Console.ReadLine();//Пишем что-нибудь в консоль, чтобы запустить программу
            string sfile = path + @"\" + file;// Указываем источник, в котором хранится файл
            string dfile = path1 + @"\" + file;// Указываем конечный пункт, в который отправится файл
            File.Move(sfile, dfile);// Перемещаем файл из первой папки во вторую
        }
    }
}