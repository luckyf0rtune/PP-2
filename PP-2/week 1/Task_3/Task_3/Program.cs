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
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split();
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(str[i]);
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} {0} ",array[i]);
            }
            Console.ReadLine();
        }
    }
}
