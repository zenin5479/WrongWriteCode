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
                  table[i, j] = chance.Next(100, 1000);
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
                  Console.Write("{0:f} ", table[i, j]);
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
         Console.Write("Введите номер строки элемента двумерного массива: ");
         int indexrow = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите номер столбца элемента двумерного массива: ");
         int indexcol = Convert.ToInt32(Console.ReadLine());
         Random grid = new Random();
         int line = grid.Next(2, 11);
         int tower = grid.Next(2, 11);
         int[,] range = new int[line, tower];

         void FillArrayInt()
         {
            Random stochastic = new Random();
            int i = 0;
            while (i < line)
            {
               int j = 0;
               while (j < tower)
               {
                  range[i, j] = stochastic.Next(10, 100);
                  j++;
               }

               i++;
            }
         }

         void PrintArrayInt()
         {
            int i = 0;
            while (i < line)
            {
               int j = 0;
               while (j < tower)
               {
                  Console.Write("{0}  ", range[i, j]);
                  j++;
               }

               i++;
               Console.WriteLine();
            }
         }

         void ValueArrayInt(int i, int j, int[,] vector)
         {
            if (i >= vector.GetLength(0) || j >= vector.GetLength(1))
            {
               Console.WriteLine("Элемента под индексом [{0}, {1}] не существует в данном массиве", i, j);
            }
            else
            {
               Console.WriteLine("Значение элемента с индексом [{0}, {1}] = {2}", i, j, vector[i, j]);
            }
         }

         FillArrayInt();

         PrintArrayInt();

         ValueArrayInt(indexrow, indexcol, range);

         Console.WriteLine("--------------------------------------------------------------------------------");
         Console.WriteLine("Cреднеарифметическое значение элементов столбцов, двумерного массива целых чисел");
         Console.WriteLine("--------------------------------------------------------------------------------");

         Random selection = new Random();
         int strip = selection.Next(2, 11);
         int pillar = selection.Next(2, 11);
         int[,] massif = new int[strip, pillar];

         void Print2DArrayInt(int[,] mas)
         {
            int i = 0;
            while (i < line)
            {
               int j = 0;
               while (j < tower)
               {
                  Console.Write("{0}  ", range[i, j]);
                  j++;
               }

               i++;
               Console.WriteLine();
            }
         }

         void AverageColumnArrayInt()
         {
            double average;
            Console.WriteLine("Среднеарифметическое столбцов:");
            int j = 0;
            while (j < pillar)
            {
               double amount = 0;
               int i = 0;
               while (i < strip)
               {
                  amount += massif[i, j];
                  i++;
               }

               average = amount / strip;
               Console.Write("{0:f} ", average);
               j++;
            }
         }

         AverageColumnArrayInt();
         Console.WriteLine();

         Console.WriteLine("----------------");
         Console.WriteLine("Умножение матриц");
         Console.WriteLine("----------------");
         Random probabilistic = new Random();
         int rowone = probabilistic.Next(3, 4);
         int colone = probabilistic.Next(3, 4);
         int[,] matrixone = new int[rowone, colone];
         int rowtwo = probabilistic.Next(3, 4);
         int coltwo = probabilistic.Next(3, 4);
         int[,] matrixtwo = new int[rowtwo, coltwo];
         // Метод заполнения массива
         void Complete2DArray(int[,] matrix)
         {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            Random masif = new Random();
            for (int i = 0; i < row; i++)
            {
               for (int j = 0; j < column; j++)
               {
                  matrix[i, j] = masif.Next(-9, 8);
               }
            }
         }

         // Метод перемножения матриц
         int[,] Multiplication(int[,] a, int[,] b)
         {
            if (a.GetLength(1) != b.GetLength(0))
            {
               if (a.GetLength(1) != b.GetLength(0))
               {
                  Console.WriteLine("Матрицы нельзя перемножить");
               }
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

         // Метод вывода массива
         void Print2DArray(int[,] c)
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

         Complete2DArray(matrixone);
         Complete2DArray(matrixtwo);
         Console.WriteLine("Матрица А:");
         Print2DArray(matrixone);
         Console.WriteLine("Матрица B:");
         Print2DArray(matrixtwo);
         Console.WriteLine("Матрица С = А * В:");
         Multiplication(matrixone, matrixtwo);
         Print2DArray(Multiplication(matrixone, matrixtwo));

         Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
         Console.WriteLine("Найдите в этом массиве и сохраните в одномерный массив все числа, сумма цифр которых больше их произведения");
         Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
         int[,] arrayy = new int[3, 4];

         // Метод заполнения двумерного массива
         void FillArrayy()
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

         // Метод определяет больше ли сумма цифр или произведение цифр элемента массива
         int CountNumArray(int Number)
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

         // Метод  перевода элементов двумерного массива по условию задачи в одномерный
         void NumberArray()
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

         // Метод вывода массива
         void PrintArrayy()
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
         FillArrayy();
         Console.WriteLine("Двумернвый массив");
         PrintArrayy();
         Console.WriteLine("Одномерный массив по условию задачи");
         NumberArray();

         int[,] griddes = new int[5, 5];
         Random rnd = new Random();

         // Заполняем массив случайными 0 и 1
         for (int i = 0; i < 5; i++)
         {
            for (int j = 0; j < 5; j++)
            {
               griddes[i, j] = rnd.Next(2);
            }
         }

         // Принудительно задаем старт и финиш единицами
         griddes[0, 0] = 1;
         griddes[4, 4] = 1;
         Console.WriteLine();
         // Выводим массив для наглядности
         Console.WriteLine("Массив:");
         for (int i = 0; i < 5; i++)
         {
            for (int j = 0; j < 5; j++)
            {
               Console.Write(griddes[i, j] + " ");
            }
            Console.WriteLine();
         }

         // Проверяем путь
         bool hasPath = CheckPath(griddes);
         Console.WriteLine(hasPath ? "Путь существует!" : "Путь не существует");

         const int size = 5;
         int[,] gridis = new int[size, size];
         Random rand = new Random();

         // Заполняем массив случайными 0 и 1
         for (int i = 0; i < size; i++)
         {
            for (int j = 0; j < size; j++)
            {
               gridis[i, j] = rand.Next(2); // 0 или 1
            }
         }

         // Принудительно ставим 1 в стартовой и конечной точках
         gridis[0, 0] = 1;
         gridis[size - 1, size - 1] = 1;

         // Выводим массив для наглядности
         Console.WriteLine("Сгенерированный массив:");
         PrintGrid(gridis);

         // Проверяем наличие пути
         bool path = HasPath(gridis);
         Console.WriteLine(path ? "Путь существует!" : "Пути нет!");

         Console.ReadLine();
      }

      static bool HasPath(int[,] grid)
      {
         const int SIZE = 5;
         bool[,] visited = new bool[SIZE, SIZE]; // Массив для отметки посещённых ячеек
         int[,] stack = new int[SIZE * SIZE, 2]; // Стек для DFS (максимально SIZE*SIZE элементов)
         int stackTop = -1; // Индекс вершины стека

         // Начинаем с [0, 0]
         stackTop++;
         stack[stackTop, 0] = 0;
         stack[stackTop, 1] = 0;

         while (stackTop >= 0)
         {
            // Достаём текущую ячейку из стека
            int row = stack[stackTop, 0];
            int col = stack[stackTop, 1];
            stackTop--;

            // Если достигли [4, 4], путь найден
            if (row == SIZE - 1 && col == SIZE - 1)
               return true;

            // Если уже посещали эту ячейку, пропускаем
            if (visited[row, col])
               continue;

            visited[row, col] = true;

            // Проверяем 4 направления: вверх, вниз, влево, вправо
            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            for (int d = 0; d < 4; d++)
            {
               int newRow = row + dr[d];
               int newCol = col + dc[d];

               // Проверяем границы массива и условие (значение = 1 и не посещена)
               if (newRow >= 0 && newRow < SIZE &&
                   newCol >= 0 && newCol < SIZE &&
                   grid[newRow, newCol] == 1 &&
                   !visited[newRow, newCol])
               {
                  // Добавляем соседнюю ячейку в стек
                  stackTop++;
                  stack[stackTop, 0] = newRow;
                  stack[stackTop, 1] = newCol;
               }
            }
         }

         return false; // Путь не найден
      }

      static void PrintGrid(int[,] grid)
      {
         for (int i = 0; i < 5; i++)
         {
            for (int j = 0; j < 5; j++)
            {
               Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
         }
      }

      static bool CheckPath(int[,] grid)
      {
         // Очередь для BFS (максимум 25 элементов)
         int[] queueX = new int[25];
         int[] queueY = new int[25];
         int front = 0, rear = 0;

         // Массив посещенных клеток
         bool[,] visited = new bool[5, 5];

         // Направления движения: вверх, вправо, вниз, влево
         int[] dx = { -1, 0, 1, 0 };
         int[] dy = { 0, 1, 0, -1 };

         // Добавляем стартовую позицию в очередь
         queueX[rear] = 0;
         queueY[rear] = 0;
         rear++;
         visited[0, 0] = true;

         while (front < rear)
         {
            // Извлекаем текущую позицию
            int x = queueX[front];
            int y = queueY[front];
            front++;

            // Если дошли до цели
            if (x == 4 && y == 4)
               return true;

            // Проверяем всех соседей
            for (int i = 0; i < 4; i++)
            {
               int nx = x + dx[i];
               int ny = y + dy[i];

               // Проверяем границы и доступность клетки
               if (nx >= 0 && nx < 5 && ny >= 0 && ny < 5 && grid[nx, ny] == 1 && !visited[nx, ny])
               {
                  // Добавляем в очередь и отмечаем посещенной
                  queueX[rear] = nx;
                  queueY[rear] = ny;
                  rear++;
                  visited[nx, ny] = true;
               }
            }
         }

         return false;
      }
   }
}