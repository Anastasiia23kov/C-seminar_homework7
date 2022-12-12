// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Задаю двумерный массив.
void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// Нахожу среднее арифметическое каждого столбца массива.
void ReleaseMatrix(int[, ] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        Console.Write($"{ sum / matrix.GetLength(0)} ");
    }
    Console.ReadLine();
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);

Console.WriteLine();

Console.WriteLine($"Количество столбцов в массиве: {matrix.GetLength(1)}");

Console.Write("Среднее арифметическое каждого столбца: ");
ReleaseMatrix(matrix);



