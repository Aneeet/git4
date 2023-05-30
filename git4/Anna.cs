using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace git4
{
   public class Anna
    {
        public static void Output(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(string.Join(" ", array[i]));
            }
        }
        
       
        public void DoBlock_1(ref int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] barray = new int[count];
            int count2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    barray[count2] = array[i];

                    count2++;

                }
            }
            array = barray;
            Console.WriteLine(string.Join(" ", array));
        }
        public void DoBlock_2(ref int[][] array)
        {
            Console.WriteLine("Введіть кількість рядків");
            string[] str = Console.ReadLine().Trim().Split();
            int num1 = int.Parse(str[0]);
            int num = 0;
            if (num1 % 2 == 0)
            {
                num = num1 / 2;
            }
            else
            {
                num = num1 / 2 + 1;
            }
            int[][] barray = new int[num][];
            int k = 0;

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    barray[k] = new int[array[i].Length];
                    barray[k] = array[i];

                    k++;
                }
            }
            array = barray;
            Console.WriteLine("Результат:");
            Output(array);
        }
    }
}
   
