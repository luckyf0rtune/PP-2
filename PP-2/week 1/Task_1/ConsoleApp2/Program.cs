using System;

namespace ConsoleApp2
{
    class Program
    {
        public static bool primenumber(int n)
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
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            string[] str = Console.ReadLine().Split();
            for(int i=0; i<arr1.Length; i++)
            {
                arr1[i] = int.Parse(str[i]);
            }
            int j = 0;
            for (int i=0; i<arr1.Length; i++)
            {
                if (primenumber(arr1[i]))
                {
                   arr2[j] = arr1[i] ;
                    cnt++;
                    j++;
                }
            }
            Console.WriteLine(cnt);
            for (int i=0; i<cnt; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
