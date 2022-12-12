//Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//1 7 -> такой позиции в массиве нет

// Задаю двумерный массив, наполненный случайными числами от 1 до 10.
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

// Определяю есть ли заданная позиция в массиве
void RealeseMatrix(int[, ] matrix)
{
    Console.WriteLine("Введите позицию элемента в массиве. Строка массива (нумерация с 0): ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите позицию элемента в массиве. Столбец массива (нумерация с 0): ");        
    int colums = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) 
            {
                Console.WriteLine($"Такая позиция в массиве есть, её значение: {matrix[rows, colums]}");
                break;
            }
            else 
            {
                Console.WriteLine($"{rows}{colums} -> такой позиции в массиве нет");
                break;
            }
        }
        break;
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];

Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);

RealeseMatrix(matrix);




