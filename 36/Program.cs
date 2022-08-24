// Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] createArray = new int [4];
Random arrayRnd = new Random();
int sum = 0;

Console.WriteLine("Массив: ");

void OneDimenArr()
{
    for (int i = 0; i < createArray.Length; i++)
    {
        createArray[i] = arrayRnd.Next(0, 10);
        Console.Write("{0} ", createArray[i]);
    }
    return;
}
void sum_odd_numbers()
{
    for(int i = 0; i < createArray.Length; i++)
    {
        if (i % 2 != 1) sum += createArray[i];
    }
    Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: {0}", sum);
}
OneDimenArr();
Console.WriteLine();
sum_odd_numbers();
Console.WriteLine();
