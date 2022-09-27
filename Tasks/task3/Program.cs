// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int height = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int width = int.Parse(Console.ReadLine()!);

int [,] matrix = new int[height, width];
CreateRandom2DArray(matrix, height, width);
Print2DArray(matrix, height, width);
FindAveragebyColumns(matrix, height, width);


void Print2DArray(int[,] matrix, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}



void CreateRandom2DArray(int[,] matrix, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix[i, j] = new Random().Next(-30, 30);
        }
    }
}

void FindAveragebyColumns(int[,] matrix, int height, int width);{
    for (int  j= 0; j < width; j++)
    {
        int sum = 0;
        int count = 0;
        double average = 0;
        for (int i = 0; i < height; i++)
        {
            sum =+ matrix[i,j];
            count++;
        } 
        average = sum / count;
        Console.WriteLine($"Среднее арифметическое элементов в столбце {j} равно {average:F3}");
    }
}

     
