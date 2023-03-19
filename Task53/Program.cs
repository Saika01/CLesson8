// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("(^3^)/");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("(^3^)/");
    }
}

void ChangeFirstLastRows(int[,] matr)
{
    int firstRow = 0;
    int lastRow = matr.GetLength(0) - 1;
    for (int j = 0; j < matr.GetLength(1); j++) //columns
    {
        int carry = matr[firstRow, j];
        matr[firstRow,j] = matr[lastRow,j];
        matr[lastRow,j] = carry;
    }
}

int[,] newMatrix = CreateMatrix(3,4,1,10);
PrintMatrix(newMatrix);
Console.WriteLine();
ChangeFirstLastRows(newMatrix);
PrintMatrix(newMatrix);
