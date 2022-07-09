/*
Напишите программу, которая не вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или уже указание,
что такого элемента нет
*/

int GetDimension(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] InitMatrix(int firstDimension, int secondDimension)
{
    int[,] matrix = new int[firstDimension, secondDimension];
    Random rnd = new Random();

    for (int i = 0; i < firstDimension; i++)
    {
        for (int j = 0; j < secondDimension; j++)
            matrix[i, j] = rnd.Next(1, 20);
    }

    return matrix;
}

string GetElementOfMatrixWithIndex(int[,] matrix, int index0, int index1)
{
    int result = 0;

    if (matrix.GetLength(0) > index0 && matrix.GetLength(1) > index1)
    {
        result = matrix[index0 - 1, index1 - 1];
        return ($"Number with this index: {result}");
    }
    else
        return ("No number with this index in matrix");
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Matrix: ");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }

        Console.WriteLine();
    }
}

int firstDimension = GetDimension("Enter length of columns: ");
int secondDimension = GetDimension("Enter length of rows: ");
int[,] matrix = InitMatrix(firstDimension, secondDimension);
PrintMatrix(matrix);

Console.WriteLine();
Console.Write("Enter index of number in matrix with comma as i,j: ");
string str = Console.ReadLine();
string[] array = str.Split(',');

int index0 = Convert.ToInt32(array[0]);
int index1 = Convert.ToInt32(array[1]);

string result = GetElementOfMatrixWithIndex(matrix, index0, index1);
Console.WriteLine();
Console.WriteLine(result);