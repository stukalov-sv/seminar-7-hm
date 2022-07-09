/*
Задайте двумерный массив из целых чисел. Найдите среднее 
арифметическое элементов в каждом столбце.
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

double[] GetAverageSumColumnsElement(int[,] matrix)
{
    double[] sumColumnsArray = new double [matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int tempColSum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
            tempColSum += matrix[i,j];
        
        sumColumnsArray[j] = tempColSum;
    }

    double[] resultArray = new double[sumColumnsArray.Length];
    for (int i = 0; i < resultArray.Length; i++)
        resultArray[i] = Math.Round((sumColumnsArray[i] / matrix.GetLength(0)), 1);

    return resultArray;
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

double[] result = GetAverageSumColumnsElement(matrix);
Console.WriteLine("Average sum of matrix columns:");
for (int i = 0; i < result.Length; i++)
    Console.Write($"{result[i]}; ");