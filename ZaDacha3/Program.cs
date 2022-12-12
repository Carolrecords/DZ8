// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Write("Введите количество строк первого массива: ");
int rows1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов первого массива: ");
int columns1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество строк второго массива: ");
int rows2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов второго массива: ");
int columns2 = int.Parse(Console.ReadLine() ?? "");


int[,] firstArray = GetArray(rows1, columns1, 0, 10);
int[,] secondArray = GetArray(rows2, columns2, 0, 10);

PrintArray(firstArray, secondArray);
Console.WriteLine($"=====================");

if (columns1 == rows2)
{
    int[,] multiArray = MultiArrays(firstArray, secondArray);
    PrintMultiArray(multiArray);
}
else
{
    Console.WriteLine($"Перемножение матриц невозможно!");
}

//=======================================================

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array1, int[,] array2)
{
    for (int i = 0; i < Math.Max(array1.GetLength(0), array2.GetLength(0)); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (i < array1.GetLength(0))
            {
                Console.Write($"{array1[i, j]} ");
            }
            else
            {
                Console.Write($"  ");
            }
        }

        Console.Write($"|| ");

        for (int k = 0; k < array2.GetLength(1); k++)
        {
            if (i < array2.GetLength(0))
            {
                Console.Write($"{array2[i, k]} ");
            }
            else
            {
                Console.Write($"  ");
            }
        }

        Console.WriteLine();
    }
}

void PrintMultiArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiArrays (int[,] array1, int[,] array2)
{   
    int[,] multi = new int[array1.GetLength(0), array2.GetLength(1)];    
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                multi[i, j] += (array1[i, k] *  array2[k, j]);
            }
        }
    }

    return multi;
}