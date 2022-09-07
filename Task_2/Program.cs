// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int m = 3;
int n = 4;
int[,] matrix = new int[m, n];

FillRndArray(matrix);
PrintArray(matrix);

Console.WriteLine();
int[] rowSum = CalculateRowArray(matrix);

Console.WriteLine();

int minSumInRow = NumMinRow(rowSum);
Console.WriteLine(minSumInRow);

int NumMinRow(int[] arr) 
{
    int min = arr[0];
    int numRow = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] < min) {
            min = arr[i];
            numRow = i;
        }
    }

    return numRow + 1;
}

int[] CalculateRowArray(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            sum[i] += arr[i, j];
        }
    }

    return sum;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillRndArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = rand.Next(0, 10);
        }
    }
}
