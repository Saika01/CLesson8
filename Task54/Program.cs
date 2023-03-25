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

void MatrixSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] newArray = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[j] = matrix[i, j];
        }
        ArraySort(newArray);
        for (int j = 0; j < newArray.Length; j++)
        {
            matrix[i,j] = newArray[j];
        }

    }
}

void ArraySort(int[] array)
{
    for(int i=0; i<array.Length-1; i++) 
    {
        for (int element = 0; element < array.Length-1; element++) 
        {
            if (array[element]<array[element+1])
            {
                int temporary = array[element];
                array[element] = array[element+1];
                array[element+1] = temporary;
            }
        }
    }
}

void PrintArray(int[] array)
{
    Console.Write("(^3^)/");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i],3} ");

    }
    Console.WriteLine("(^3^)/");
}

int[] CreateArray(int elements, int min, int max)
{
    int[] array = new int[elements];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[,] newMatrix = CreateMatrix(3,3,1,10);
PrintMatrix(newMatrix);
Console.WriteLine();
MatrixSort(newMatrix);
PrintMatrix(newMatrix);

