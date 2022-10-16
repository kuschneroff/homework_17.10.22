/*
Задача 36: Задайте одномерный массив,
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] RandomArray()
{
    int [] massiv = new int[6];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(-10, 10);
    }
    return massiv;
}

void PrintResult(int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
}

int SummElements(int [] massiv)
{
    int summ = 0;
    for (int i = 1; i < massiv.Length; i+=2)
    {
        summ = summ + massiv[i];
    }
    return summ;
}

int  [] arr = RandomArray();
PrintResult(arr);
Console.WriteLine();
int resultSumm = SummElements(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {resultSumm}");

