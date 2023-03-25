// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

Console.WriteLine("Input number of rows");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начало диапазона случайного числа, значения массива: ");
int startValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапазона случайного числа, значения массива: ");
int endValue = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateMatrix(row, col, startValue, endValue);
PrintMatrix(array);

Console.WriteLine();

int[] newArr = MatrixToArray(array);
Array.Sort(newArr);
PrintArray(newArr);

Console.WriteLine();

FrequencyDictionaryFromArray(newArr);

void FrequencyDictionaryFromArray(int[] array)
{ 
    int currentValue = array[0]; 
    int counter = 1; 
    for (int i = 1; i < array.Length; i++) 
    { 
        if (array[i] == currentValue) counter++; 
        else { 
            Console.WriteLine($"{currentValue} -> {counter}");
            currentValue = array[i];
            counter = 1;
        }
    }
    Console.WriteLine($"{currentValue} -> {counter}");
}

int[] MatrixToArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[count] = matrix[i,j];
            count++;
        }
    }
    return newArray;
}

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

void PrintArray(int[] array)
{
    Console.Write("(^3^)/");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],4} ");
    }
    Console.WriteLine("(^3^)/");
}
