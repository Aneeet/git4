using System;
using System.Collections.Generic;
using System.Text;

namespace git4
{
    public class Kiril
    {
        public void DoBlock_1(ref int[] array)
        {
            Console.WriteLine("Введіть кількість елементів для вставки.");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть індекс, починаючи з якого треба вставляти нові елементи");
            int t = int.Parse(Console.ReadLine());
            if (t < array.Length && t >= 0)
            {
                Console.WriteLine("Введіть елементи які треба ввести.");
                int[] elements = new int[k];
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = int.Parse(Console.ReadLine());

                }

                InsertElements(ref array, k, t, elements);

                foreach (int elem in array)
                {
                    Console.Write(elem + " ");
                }
            }
            else
            {
                Console.WriteLine("ERROR.");
            }
        }
        public static void InsertElements(ref int[] array, int k, int t, int[] elements)
        {
            int n = array.Length;
            int[] newArray = new int[n + k];            // створюємо новий масив з необхідною довжиною

            for (int i = 0; i < t; i++)                 // йдемо по масиву до t і копіюємо всі елем
            {
                newArray[i] = array[i];
            }

            for (int i = 0; i < k; i++)                 // вставляємо нові елементи
            {
                newArray[t + i] = elements[i];
            }

            for (int i = t; i < n; i++)                 // далі йдемо по масиву з t і до кінця, копіючи елементи з arr
            {
                newArray[k + i] = arr[i];
            }

            array = newArray;                             // вхідний масив на новий.
        }
        public void DoBlock_2(ref int[][] array)
        {

            Console.WriteLine("Початкова зубчаста матриця:");
            PrintJaggedMatrix(array);

            int[][] modifiedMatrix = AddRowsAfterEvenRows(array);

            Console.WriteLine("Зубчаста матриця з доданими рядками:");
            PrintJaggedMatrix(modifiedMatrix);
        }
        public static void PrintJaggedMatrix(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[][] AddRowsAfterEvenRows(int[][] array)
        {
            int rowCount = array.Length;
            int newRowCount = rowCount + rowCount / 2;                     // Визначення нової кількості рядків

            int[][] modifiedMatrix = new int[newRowCount][];
            int rowIndex = 0;

            for (int i = 0; i < rowCount; i++)
            {
                modifiedMatrix[rowIndex] = array[i];                       // Копіювання початкового рядка в нову матрицю

                rowIndex++;

                if ((i + 1) % 2 == 0 && rowIndex < newRowCount)               // Перевірка, чи індекс не виходить за межі нової матриці
                {
                    modifiedMatrix[rowIndex] = new int[array[i].Length];   // Створення нового рядка з такою ж кількістю елементів

                    rowIndex++;
                }
            }
            return modifiedMatrix;
        }
    }
}
