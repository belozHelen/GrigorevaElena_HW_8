// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
//  Матрицы можно создать рандомным способом. Матрицы равны по колличеству строк и столбцов, а элементы у них могут быть разные. 
// Умножаем соответсвующие элемменты друг на друга и получаете произведение.

int m = 3;
int n = 3;
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
int[,] matrix3 = new int[m, n];

FillRndArray(matrix1);
PrintArray(matrix1);

Console.WriteLine();

FillRndArray(matrix2);
PrintArray(matrix2);

Console.WriteLine();

CalculateMatrix(matrix1, matrix2, matrix3);

PrintArray(matrix3);

void CalculateMatrix(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++) {
        for (int j = 0; j < arr1.GetLength(1); j++) {
            arr3[i,j] = arr1[i,j] * arr2[i,j];
        }
    }
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