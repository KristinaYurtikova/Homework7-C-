// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int height = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int width = int.Parse(Console.ReadLine()!);

double[,] matrix = new double[height, width];
CreateRandom2DArray(matrix, height, width);
Print2DArray(matrix, height, width);
FindElementsInPosition(matrix, height, width);


void Print2DArray(double[,] matrix, int height, int width)
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



void CreateRandom2DArray(double[,] matrix, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix[i, j] = new Random().Next(-100, 100);
        }
    }
}

void FindElementsInPosition(double[,] matrix, int height, int width)
{

    Console.Write("Укажите позицию элемента по горизонтали: ");
    int HeightIndex = int.Parse(Console.ReadLine()!);

    Console.Write("Укажите позицию элемента по вертикали: ");
    int WidthIndex = int.Parse(Console.ReadLine()!);
    if (HeightIndex <= height && WidthIndex <= width)
        Console.WriteLine($"Элемент на этой позиции {matrix[HeightIndex - 1, WidthIndex - 1]}");

    else
        Console.WriteLine("Такого элемента в массиве не существует");

}