int[,,] CreateMatrix3(int firstDymention, int secondDymention, int thirdDymention, int min, int max)
{
    int[,,] matrix3 = new int[firstDymention, secondDymention, thirdDymention];
    Random rnd = new Random();
    for (int i = 0; i < matrix3.GetLength(0); i++) //1 dymention
    {
        for (int j = 0; j < matrix3.GetLength(1); j++) //2 dymention
        {
            for (int z = 0; z < matrix3.GetLength(2); z++) //3 dymention
            {
                matrix3[i, j, z] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix3;
}

void PrintMatrix3(int[,,] matrix3)
{
    for (int i = 0; i < matrix3.GetLength(0); i++)
    {

        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int z = 0; z < matrix3.GetLength(2); z++)
            {
                Console.Write($"{matrix3[i, j, z],4}({i},{j},{z})");
            }
        }
        Console.WriteLine();
    }
}

int[,,] newMatrix = CreateMatrix3(2,2,2,10,100);
PrintMatrix3(newMatrix);


