//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.

int rowsTask1 = new Random().Next(3, 5);
int columnsTask1 = new Random().Next(3, 4);
double[,] arrayTask1 = new double[rowsTask1, columnsTask1];

CreateArrayDouble(arrayTask1);
PrintArrayDouble(arrayTask1);

void CreateArrayDouble(double[, ] array)
{    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
}

void PrintArrayDouble(double[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
         Console.WriteLine();
    }
}

//Задача 2.  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

int rowsTask2 = new Random().Next(3, 5);
int columnsTask2 = new Random().Next(3, 4);
int[,] arrayTask2 = new int[rowsTask2, columnsTask2];

CreateArray(arrayTask2);
PrintArray(arrayTask2);
Console.WriteLine("Введите значение строки и колонки для элемента, например 1, 2");
int indexRow = Convert.ToInt32(Console.ReadLine());
int indexColumn = Convert.ToInt32(Console.ReadLine());
FindElementValue(arrayTask2, indexRow, indexColumn);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 30);
        }
    }
}


void FindElementValue(int[,] array, int indexRow, int indexColumn)
{
    if (indexRow <= array.GetLength(0) && indexColumn<= array.GetLength(1))
    {
        Console.WriteLine($"значение эелемента равно {array[indexRow, indexColumn]}");
    }
    else if (indexRow > array.GetLength(0) || indexColumn<= array.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
    }
}


void PrintArray(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
         Console.WriteLine();
    }
}

//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

int rowsTask3 = new Random().Next(3, 5);
int columnsTask3 = new Random().Next(3, 4);
int[,] arrayTask3 = new int[rowsTask3, columnsTask3];

CreateArray(arrayTask3);
PrintArray(arrayTask3);
GetArithmeticMean(arrayTask3);

void GetArithmeticMean(int[, ] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           sum += array[i, j];
           count++;
        }
        Console.WriteLine($"среднее арифметисекое равно {sum/count}");
    }
}



