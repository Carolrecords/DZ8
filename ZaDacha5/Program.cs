// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = new int[rows, columns];

SpiralArray(0, 0);
PrintArray(array);

//=======================================================

void SpiralArray(int row, int col)
{
    int index = 1;
    int reduction = 0; // переменная, которая позволяет за цикл обхода прямоугольник, уменьшить последующий прямоугольник

    while (index <= rows * columns)
    {
        array[row, col] = index;
        if (row == reduction && col < columns - reduction - 1)
            col++;
        else if (col == columns - reduction - 1 && row < rows - reduction - 1)
            row++;
        else if (row == rows - reduction - 1 && col > reduction)
            col--;
        else
            row--;

        if (row == reduction + 1 && col == reduction && reduction != columns - reduction - 1)
        {
            reduction++;
        }
        index++;
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{inArray[i, j]} ");

            else
                Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
