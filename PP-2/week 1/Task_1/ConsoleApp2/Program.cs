using System;

namespace Task1
{
    class Program
    {
        public static bool primenumber(int n)//Создаём функцию под названием "primenumber"
        {
            if (n == 1) {
                return false; }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
                return true;
            }

       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); /*Вводим число для определения длины нашего последующего массива,
            и делаем так, чтобы программа принимала числовое значение переменной*/
            int cnt = 0; //Создаём счётчик простого числа
            int[] arr1 = new int[n]; //Создание массива arr1 с длиной n
            int[] arr2 = new int[n]; //Создание массива arr2 с длиной n (где будут показываться простые числа)
            string[] str = Console.ReadLine().Split(); //Создаём строку и делаем так, чтобы в консоли элементы массива, разделялись пробелом
            for(int i=0; i<arr1.Length; i++)//Цикл для того, чтобы программа прошлась по массиву с заданными числами
            {
                arr1[i] = int.Parse(str[i]);
            }
            int j = 0;// Создание итератора для введёного массива
            for (int i=0; i<arr1.Length; i++) //Проверка для простых чисел из первого массива arr1 и добавление их во второй массив arr2
            {
                if (primenumber(arr1[i]))
                {
                   arr2[j] = arr1[i] ;
                    cnt++;
                    j++;
                }
            }
            Console.WriteLine(cnt);//Вывод количества элементов второго массива простых чисел
            for (int i=0; i<cnt; i++)//Вывод элементов "Простых чисел" 
            {
                Console.Write(arr2[i] + " ");//Вывод простых чисел в консоль, разделяя пробелом
            }
            Console.ReadLine();//Команда для того, чтобы консоль не закрылось после завершения программы
        }
    }
}
