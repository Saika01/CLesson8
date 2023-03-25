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

int RowNumberSmallestSum(int[,] matrix)
{
    int smallestSum = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        smallestSum += matrix[0,n];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < smallestSum) return i;
    }
    return 0;
}

int[,] newMatrix = CreateMatrix(3, 4, 1, 5);
PrintMatrix(newMatrix);

int rowNumberSmallestSum = RowNumberSmallestSum(newMatrix);
Console.WriteLine($"{rowNumberSmallestSum+1}th row");


