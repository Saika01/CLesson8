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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int size = firstMatrix.GetLength(0);
    int[,] matrixesMultiplied = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            int sum = 0;
            if (firstMatrix.GetLength(1) <= secondMatrix.GetLength(0))
            {
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                matrixesMultiplied[i, j] = sum;
            }
            else if (firstMatrix.GetLength(1) > secondMatrix.GetLength(0))
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                matrixesMultiplied[i, j] = sum;
            }
        }
    }
    return matrixesMultiplied;
}

Console.WriteLine("Input numeber of rows for the first matrix");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numeber of columns for the first matrix");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of rows for the second matrix");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns for the second matrix");
int col2 = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix1 = CreateMatrix(row1, col1, 1, 10);
PrintMatrix(newMatrix1);

Console.WriteLine();

int[,] newMatrix2 = CreateMatrix(row2, col2, 1, 10);
PrintMatrix(newMatrix2);

Console.WriteLine();

if (col1 != row2) Console.WriteLine("Error");
else
{
    int[,] matrixMultiplication = MatrixMultiplication(newMatrix1, newMatrix2);
    PrintMatrix(matrixMultiplication);
}



