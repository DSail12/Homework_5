// Задача 34 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine ("Укажите пожалуйста размер массива: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int [] createArray()
{
    var random = new Random();
    var total = new int[a];
    for (long i = 0; i < total.Length; i++)
    {
        total[i] = random.Next(100, 1000);
    }
    return total;
}
int Even_Numbers(int[] array)
{
    var total = 0;
    for (long i = 0; i< array.Length; i++)
    if (array[i] % 2 == 0)
    total++;
    return total;

}
void printArray(int[] array)
{
    
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        Console.Write(", ");
    }
   
    Console.WriteLine();
}
var array = createArray();
printArray(array);
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве равно: ");
Console.WriteLine(Even_Numbers(array));