﻿// Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите пожалуйста размер массива");
int a =int.Parse(Console.ReadLine()!);
Console.WriteLine();

double[] createArray()
{
    Random randome = new Random();
    double[] result = new double[a];
    for (long i = 0; i < result.Length; i++)
    {
        result[i] = randome.Next(1, 100);
    }
    return result;
}
void Sort(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine("MAX " + max);
    Console.WriteLine("MIN " + min);
    Console.WriteLine();
    double result = max - min;
    Console.WriteLine(result);

}

void printArray(double[] array)
{
    Console.Write("[");

    for (long i = 0; i< array.Length; i++)
    {
        Console.Write(array[i]);
        {
            Console.Write("   ");
        }
       
    }
    Console.Write("]");
    Console.WriteLine();
}
double[] array = createArray();

Sort(array);
printArray(array);
