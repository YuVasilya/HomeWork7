// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] CreateMatrix(int m, int n)
{
    return new int[m, n];
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
FillMatrix(matrix);
PrintMatrix(matrix);

Console.Write("Введите номер строки = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите номер столбца = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int FindNumber(int[,] matrix, int row, int col)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (row == i && col == j) Console.WriteLine($"Искомое число = {matrix[i, j]}");
 //               if (row != i || col != j) Console.WriteLine("Такого числа нет."); 
 //закоммитила т.к запись выходит при каждом запуске метода
            }
    }    
    return matrix[row, col];
}

FindNumber(matrix, n, m);


