// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int height = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int width = int.Parse(Console.ReadLine()!);

double[,] matrix = new double [height, width];
CreateRandom2DArray(matrix, height, width);
Print2DArray(matrix, height, width);


void Print2DArray(double[,] matrix, int height, int width){
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{matrix[i,j],3}");
        }
        Console.WriteLine();
    }
}    
}


void CreateRandom2DArray(double [,] matrix, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble() * 100, 2, MidpointRounding.AwayFromZero);
        }
    }
}



