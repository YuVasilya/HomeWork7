// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

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

double FindColumnArithmeticMean(int[,] matrix)
{
    double sum = 0;
    int count = 0;
    double arithmeticMean = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i< matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        count ++;
        arithmeticMean = sum/count;
        Console.Write($"{Math.Round(arithmeticMean, 1)}; ");
    }
    return arithmeticMean;
}

int[,] numbers = CreateMatrix(3,4);
FillMatrix(numbers);
PrintMatrix(numbers);
Console.WriteLine($"Среднее арифметическое {numbers.GetLength(1)} строк равно: ");
FindColumnArithmeticMean(numbers);
