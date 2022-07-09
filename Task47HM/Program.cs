/*
Задайте двумерный массив размером m x n, 
заполненный случайными вещественными числами
*/

int GetDimension(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] InitMatrix(int firstDimension, int secondDimension)
{
    double[,] matrix = new double[firstDimension, secondDimension];
    Random rnd = new Random();

    for (int i = 0; i < firstDimension; i++)
    {
        for (int j = 0; j < secondDimension; j++)
            matrix[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine("Matrix:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}   ");

        Console.WriteLine();
    }
}

int firstDimension = GetDimension("Enter length of columns: ");
int secondDimension = GetDimension("Enter length of rows: ");

double[,] resultMatrix = InitMatrix(firstDimension, secondDimension);
PrintMatrix(resultMatrix);