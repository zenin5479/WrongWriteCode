using System;

// Как не нужно писать код
// Задача: Задайте двумерный массив размером mxn, заполненный случайными вещественными числами
// Задача: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет
// Задача: Задайте двумерный массив из целых чисел
// Найдите среднее арифметическое элементов в каждом столбце
// Задача: Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9
// Выполните умножение матриц
// Задача: Двумерный массив размером 3х4 заполнен числами от 100 до 9999
// Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения
// Выведите оба массива
// Задача: Двумерный массив размером 5х5 заполнен случайными нулями и единицами
// Игрок может ходить только по полям, заполненным единицами
// Проверьте, существует ли путь из точки [0, 0] в точку[4, 4] (эти поля требуется принудительно задать равными единице)

namespace WrongWriteCode
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("----------------------------------------------");
         Console.WriteLine("Двумерный массив, случайных вещественных чисел");
         Console.WriteLine("----------------------------------------------");
         int n;
         void SizeRow()
         {
            do
            {
               Console.Write("Введите количество строк массива: ");
               int.TryParse(Console.ReadLine(), out n);
               if (n <= 1 || n > 10)
               {
                  Console.WriteLine("Введено неверное значение");
               }
            } while (n <= 1 || n > 10);
         }

         SizeRow();

         int m;
         void SizeColumn()
         {
            do
            {
               Console.Write("Введите количество столбцов массива: ");
               int.TryParse(Console.ReadLine(), out m);
               if (m <= 1 || m > 10)
               {
                  Console.WriteLine("Введено неверное значение");
               }
            } while (m <= 1 || m > 10);
         }

         SizeColumn();

         double[,] table = new double[n, m];
         void FillArrayDouble()
         {
            Random chance = new Random();
            int i = 0;
            while (i < n)
            {
               int j = 0;
               while (j < m)
               {
                  table[i, j] = Math.Round((chance.NextDouble() * chance.Next(-999, 1000)), 1);
                  j++;
               }

               i++;
            }
         }

         void PrintArrayDouble()
         {
            int i = 0;
            while (i < n)
            {
               int j = 0;
               while (j < m)
               {
                  Console.Write("{0}\t", table[i, j]);
                  j++;
               }

               i++;
               Console.WriteLine();
            }
         }

         FillArrayDouble();

         PrintArrayDouble();

         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Проверка наличия элемента в двумерном массиве");
         Console.WriteLine("---------------------------------------------");
         Console.WriteLine("Найдите среднее арифметическое элементов в каждом столбце");
         Console.Write("Введите номер строки элемента двумерного массива: ");
         int indexrow = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите номер столбца элемента двумерного массива: ");
         int indexcol = Convert.ToInt32(Console.ReadLine());
         Random grid = new Random();
         int line = grid.Next(2, 11);
         int tower = grid.Next(2, 11);
         int[,] range = new int[line, tower];

         void FillArr()
         {
            Random stochastic = new Random();
            
            int i = 0;
            while ( i < line)
            {
               
               for (int j = 0; j < tower; j++)
               {
                  range[i, j] = stochastic.Next(10, 100);
               }
               
               i++;
            }
         }

         void PrintArr()
         {
            for (int i = 0; i < line; i++)
            {
               for (int j = 0; j < tower; j++)
               {
                  Console.Write(" {0}  ", range[i, j]);
               }
               Console.WriteLine();
            }
         }

         void ValueArr(int i, int j, int[,] arr)
         {
            if (i >= arr.GetLength(0) || j >= arr.GetLength(1))
            {
               Console.WriteLine($"элемента под индексом [{i}, {j}] не существует в данном массиве");
            }
            else
            {
               Console.WriteLine($"значение элемента под индексом [{i}, {j}]  = {arr[i, j]}");
            }
         }

         void AverValueColumnsArr()
         {
            double sr = 0;
            Console.WriteLine("Среднеарифмитическое столбцов:");
            for (int j = 0; j < tower; j++)
            {
               double sum = 0;
               for (int i = 0; i < line; i++)
               {
                  sum += range[i, j];
               }
               sr = sum / line;
               Console.Write(sr + "  ");
            }
         }

         FillArr();

         PrintArr();

         ValueArr(indexrow, indexcol, range);
         Console.WriteLine("");
         PrintArr();
         Console.WriteLine("");
         AverValueColumnsArr();

         Console.WriteLine();

         Console.WriteLine("----------------");
         Console.WriteLine("Умножение матриц");
         Console.WriteLine("----------------");

         Random rnd1 = new Random();
         int row1 = rnd1.Next(3, 4);
         int column1 = rnd1.Next(3, 4);
         int[,] arr1 = new int[row1, column1];
         int row2 = rnd1.Next(3, 4);
         int column2 = rnd1.Next(3, 4);
         int[,] arr2 = new int[row2, column2];

         FillArr1(arr1);
         FillArr1(arr2);
         Console.WriteLine("Матрица А");
         PrintArr1(arr1);
         Console.WriteLine("Матрица B");
         PrintArr1(arr2);
         Console.WriteLine("Матрица С = А * В :");
         Multiplication(arr1, arr2);
         PrintArr1(Multiplication(arr1, arr2));

         int[,] Multiplication(int[,] a, int[,] b)                            // метод перемножения матриц
         {
            if (a.GetLength(1) != b.GetLength(0))
            {
               if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");  // принудительная генерация исключения 
            }
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
               for (int j = 0; j < b.GetLength(1); j++)
               {
                  for (int k = 0; k < b.GetLength(0); k++)
                  {
                     r[i, j] += a[i, k] * b[k, j];
                  }
               }
            }

            return r;
         }

         void PrintArr1(int[,] c)                                             // метод вывода массива
         {
            for (int i = 0; i < c.GetLength(0); i++)
            {
               for (int j = 0; j < c.GetLength(1); j++)
               {
                  Console.Write("{0} ", c[i, j]);
               }
               Console.WriteLine();
            }
         }

         void FillArr1(int[,] array)                                           // метод запорлнения массива
         {
            int row = array.GetLength(0);
            int column = array.GetLength(1);
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
               for (int j = 0; j < column; j++)
               {
                  array[i, j] = rand.Next(-9, 8);
               }

            }
         }

         Console.WriteLine();

         Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
         Console.WriteLine("Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения");
         Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

         int[,] arrayy = new int[3, 4];
         FillArrayy();
         Console.WriteLine("Двумернвый массив");
         PrintArrayy();
         Console.WriteLine("Одномерный массив по условию задачи");
         NumberArray();

         void FillArrayy()                                  // метод заполнения двумерного массива
         {
            int row = arrayy.GetLength(0);
            int column = arrayy.GetLength(1);
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
               for (int j = 0; j < column; j++)
               {
                  arrayy[i, j] = rand.Next(100, 9998);
               }

            }
         }

         int CountNumArray(int Number)                      // метод определяет больше ли сумма цифр или произведение цифр элемента массива
         {
            int MultCount = 1;
            int SumCount = 0;
            int num = 0;
            while (Number > 0)
            {
               num = Number - Number / 10 * 10;
               Number = Number / 10;
               SumCount += num;
               MultCount *= num;
            }
            if (SumCount > MultCount) return 1;
            else return 0;
         }

         void NumberArray()                                 // метод  перевода элементов двумерного массива по условию задачи в одномерный
         {
            int row = arrayy.GetLength(0);
            int column = arrayy.GetLength(1);
            int count = 0;
            int m = 0;
            for (int i = 0; i < row; i++)
            {
               for (int j = 0; j < column; j++)
               {
                  if (CountNumArray(arrayy[i, j]) == 1) count++;
               }
            }
            if (count != 0)
            {
               int[] array = new int[count];

               for (int i = 0; i < row; i++)
               {
                  for (int j = 0; j < column; j++)
                  {
                     if (CountNumArray(arrayy[i, j]) == 1)
                     {
                        array[m] = arrayy[i, j];
                        Console.Write(array[m] + "  ");
                        m++;
                     }
                  }
               }
            }
            else Console.WriteLine(" ни один из элементов массива не удовлетворил условию задачи");
         }

         void PrintArrayy()                                 // мсетод вывода массива
         {
            int row = arrayy.GetLength(0);
            int column = arrayy.GetLength(1);
            for (int i = 0; i < row; i++)
            {
               for (int j = 0; j < column; j++)
               {
                  Console.Write(" {0}  ", arrayy[i, j]);
               }
               Console.WriteLine();
            }
         }

         Console.WriteLine();

         Console.ReadLine();
      }
   }
}