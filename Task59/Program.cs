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

int[] MinimalValue(int[,] matrix)
{
    int minIndexRow = 0;
    int minIndexCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] < matrix[minIndexRow, minIndexCol])
            {
                minIndexRow = i;
                minIndexCol = j;
            }
        }
    }
    return new int[] {minIndexRow, minIndexCol};
}

int[,] RemoveRowColumn(int[,] matrix, int[] arrayToRemove)
{
    int[,] newnewMatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newnewMatrix.GetLength(0); i++)
    {
        if(m==arrayToRemove[0])m++;
        for (int j = 0; j < newnewMatrix.GetLength(1); j++)
        {
            if(n==arrayToRemove[1])n++;
            newnewMatrix[i,j] = matrix[m,n];
            n++;
        }
        m++;
        n=0;
    }
    return newnewMatrix;
}

Console.WriteLine("Input number of rows");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало диапазона случайного числа, значения массива: ");
int startValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапазона случайного числа, значения массива: ");
int endValue = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = CreateMatrix(row,col,startValue,endValue);
PrintMatrix(newMatrix);

Console.WriteLine();

int[] indexesMinValue = MinimalValue(newMatrix);

int[,] removedRowColumn = RemoveRowColumn(newMatrix,indexesMinValue);

PrintMatrix(removedRowColumn);

