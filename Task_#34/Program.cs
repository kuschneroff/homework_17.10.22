/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Сгенерированный массив из случайных положительных трёхзначных чисел");

int [] RandomArray()
{
    int [] array = new int [10];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int AnEvenNumber(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {            
            if(array[i] % 2 == 0)
            count += 1;
        }
    return count;
}
int [] arr = RandomArray();
PrintArray(arr);
Console.WriteLine();
int countAnEvenNumber = AnEvenNumber(arr);
Console.WriteLine($"Количество чётных чисел в массиве = {countAnEvenNumber}");