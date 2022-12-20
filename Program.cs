// Домашняя работа 7

// Задача 1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Введите количество строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m,n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for(int j = 0;j < array.GetLength(1);j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
        }
    }
}
void PrintArray(double[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" [ ");
        for (int j = 0 ;j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}
*/

// Задача 2.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*

Console.WriteLine("Введите номер строки : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца : ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);

if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($" Значение элемента {m} строки и {n} столбца равно { numbers[m-1,n-1]}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(-100,100)/10;
        }
    }
}
void PrintArray(int [,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" [ ");
        for (int j = 0 ;j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}

*/

// Задача 3.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов : ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [m,n];
FillArrayRandomNumbers(numbers);

for ( int j = 0;j < numbers.GetLength(1);j++)
{
    double avarage = 0;
    for (int i = 0;i < numbers.GetLength(0);i++)
    {
        avarage = (avarage + numbers[i,j]);
    }
        avarage = avarage / m;
        Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for ( int i = 0; i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next( 0 ,10);
        }
    }
}
void PrintArray(int [,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" [ ");
        for (int j = 0 ;j < array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + "  ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}