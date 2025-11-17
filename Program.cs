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

         Console.WriteLine("--------------------");
         Console.WriteLine("Cреднеарифметическое");
         Console.WriteLine("--------------------");
         Random selection = new Random();
         int strip = selection.Next(2, 11);
         int pillar = selection.Next(2, 11);
         int[,] massif = new int[strip, pillar];
         // Метод заполнения массива
         void Complete2DArrayInt(int[,] panoply)
         {
            int row = panoply.GetLength(0);
            int column = panoply.GetLength(1);
            Random stochastic = new Random();
            int i = 0;
            while (i < row)
            {
               int j = 0;
               while (j < column)
               {
                  panoply[i, j] = stochastic.Next(10, 100);
                  j++;
               }

               i++;
            }
         }

         void Print2DArrayInt(int[,] group)
         {
            int i = 0;
            while (i < group.GetLength(0))
            {
               int j = 0;
               while (j < group.GetLength(1))
               {
                  Console.Write("{0}\t", group[i, j]);
                  j++;
               }

               i++;
               Console.WriteLine();
            }
         }

         void AverageColumn2DArrayInt(int[,] series)
         {
            double average;
            Console.WriteLine("Среднеарифметическое значение элементов столбцов, двумерного массива целых чисел: ");
            int j = 0;
            while (j < pillar)
            {
               double amount = 0;
               int i = 0;
               while (i < strip)
               {
                  amount += series[i, j];
                  i++;
               }

               average = amount / strip;
               Console.Write("{0:f}\t", average);
               j++;
            }
         }

         Complete2DArrayInt(massif);

         Print2DArrayInt(massif);

         AverageColumn2DArrayInt(massif);
         Console.WriteLine();

         Console.WriteLine("----------------");
         Console.WriteLine("Умножение матриц");
         Console.WriteLine("----------------");
         Random probabilistic = new Random();
         int rowone = probabilistic.Next(3, 5);
         int colone = probabilistic.Next(3, 5);
         int[,] matrixone = new int[rowone, colone];
         int rowtwo = probabilistic.Next(3, 5);
         int coltwo = probabilistic.Next(3, 5);
         int[,] matrixtwo = new int[rowtwo, coltwo];
         // Метод заполнения массива
         void Complete2DArray(int[,] matrix)
         {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            Random casual = new Random();
            int i = 0;
            while (i < row)
            {
               int j = 0;
               while (j < column)
               {
                  matrix[i, j] = casual.Next(-9, 10);
                  j++;
               }

               i++;
            }
         }

         // Метод перемножения матриц
         int[,] Multiplication(int[,] a, int[,] b)
         {
            // Совместимость размеров:
            // если матрица A имеет размер m × n, а матрица B — n × k, то результирующая матрица будет m × k
            // Ошибка при несовместимости:
            // если n не совпадает, возникнет ошибка
            int[,] outputs;
            if (a.GetLength(1) == b.GetLength(0))
            {
               outputs = new int[a.GetLength(0), b.GetLength(1)];
               int i = 0;
               while (i < a.GetLength(0))
               {
                  int j = 0;
                  while (j < b.GetLength(1))
                  {
                     int k = 0;
                     while (k < b.GetLength(0))
                     {
                        outputs[i, j] += a[i, k] * b[k, j];
                        k++;
                     }

                     j++;
                  }

                  i++;
               }

               Console.WriteLine("Матрица С = А * В:");
            }
            else
            {
               outputs = new int[0, 0];
            }

            return outputs;
         }

         // Метод вывода массива
         void Print2DArray(int[,] c)
         {
            if (c.GetLength(0) == 0 && c.GetLength(1) == 0)
            {
               Console.WriteLine("Матрицы нельзя перемножить");
            }
            else
            {
               int i = 0;
               while (i < c.GetLength(0))
               {
                  int j = 0;
                  while (j < c.GetLength(1))
                  {
                     Console.Write("{0}\t", c[i, j]);
                     j++;
                  }

                  i++;
                  Console.WriteLine();
               }
            }
         }

         Complete2DArray(matrixone);
         Complete2DArray(matrixtwo);
         Console.WriteLine("Матрица А:");
         Print2DArray(matrixone);
         Console.WriteLine("Матрица B:");
         Print2DArray(matrixtwo);
         int[,] matrixthree = Multiplication(matrixone, matrixtwo);
         Print2DArray(matrixthree);

         Console.WriteLine("---------------------------------------------------------------------------------------------------");
         Console.WriteLine("Поиск элементов в двумерном целочисленном массиве, для которых сумма цифр превышает их произведение");
         Console.WriteLine("---------------------------------------------------------------------------------------------------");
         int[,] array2DInt = new int[3, 4];

         // Метод заполнения двумерного массива
         void FillTable2DInt()
         {
            int row = array2DInt.GetLength(0);
            int col = array2DInt.GetLength(1);
            Random chance = new Random();
            int i = 0;
            while (i < row)
            {
               int j = 0;
               while (j < col)
               {
                  array2DInt[i, j] = chance.Next(100, 10000);
                  j++;
               }

               i++;
            }
         }

         // Метод определяет больше ли сумма цифр или произведение цифр элемента массива
         int DefinesSumOrWorkNumbers(int digit)
         {
            int multCount = 1;
            int sumCount = 0;
            int numeral;
            while (digit > 0)
            {
               numeral = digit - digit / 10 * 10;
               digit /= 10;
               sumCount += numeral;
               multCount *= numeral;
            }

            if (sumCount > multCount)
            {
               return 1;
            }

            return 0;
         }

         // Метод перевода элементов двумерного массива по условию задачи в одномерный
         void Converting2DTableTo1DTable()
         {
            int rows = array2DInt.GetLength(0);
            int columns = array2DInt.GetLength(1);
            int count = 0;
            int row = 0;
            int i = 0;
            while (i < rows)
            {
               for (int j = 0; j < columns; j++)
               {
                  if (DefinesSumOrWorkNumbers(array2DInt[i, j]) == 1)
                  {
                     count++;
                  }
               }
               
               
               i++;
            }

            if (count != 0)
            {
               int[] array = new int[count];

               for (int k = 0; k < rows; k++)
               {
                  for (int l = 0; l < columns; l++)
                  {
                     if (DefinesSumOrWorkNumbers(array2DInt[k, l]) == 1)
                     {
                        array[row] = array2DInt[k, l];
                        Console.Write(array[row] + "  ");
                        row++;
                     }
                  }
               }
            }
            else
            {
               Console.WriteLine("Массив не содержит элементов, для которых выполняется условие");
            }
         }

         // Метод вывода массива
         void PrintTable()
         {
            int row = array2DInt.GetLength(0);
            int column = array2DInt.GetLength(1);
            for (int i = 0; i < row; i++)
            {
               for (int j = 0; j < column; j++)
               {
                  Console.Write("{0}\t", array2DInt[i, j]);
               }
               Console.WriteLine();
            }
         }

         FillTable2DInt();
         Console.WriteLine("Двумерный массив");
         PrintTable();
         Console.WriteLine("Одномерный массив элементов, сумма цифр которых превышает их произведение");
         Converting2DTableTo1DTable();

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