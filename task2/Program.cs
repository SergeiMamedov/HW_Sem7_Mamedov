// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] matrix = new int[3, 3];
FillArray(matrix);
PrintArray(matrix);

System.Console.WriteLine("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите индекс столбца: ");
int col = Convert.ToInt32(Console.ReadLine());

if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
{
    Console.WriteLine(matrix[row, col]);
}
else 
{
    Console.WriteLine($"{row}{col} -> такого числа в массиве нет");
}