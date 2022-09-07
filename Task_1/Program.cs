// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// Сортируем по возрастанию каждую строку, весь массив не нужно. Сортируем каждую строку отдельно. 
// Нужно 3 for - 2 которые будут обходить каждый элемент, и еще 3й for который элемент на строке ставит на свое место.


int m = 5;
int n = 5;
int[,] matrix = new int[m, n];

FillRndArray(matrix);
PrintArray(matrix);

Console.WriteLine();

matrix = SortRowArray(matrix);
Console.WriteLine();

PrintArray(matrix);

int[,] SortRowArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) {
        int[] row = new int[matr.GetLength(1)];
        for (int j = 0; j < matr.GetLength(1); j++) {
            row[j] = matr[i,j];
        }
        row = SortArray(row);
        for (int x = 0; x < row.Length; x++) {
            matrix[i, x] = row[x];
        }
    }

    return matrix;
}

int[] SortArray(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    return arr;
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
