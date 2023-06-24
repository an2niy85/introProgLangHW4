/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int Promt(string meassage)
{
    Console.Write(meassage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

Console.Clear();
int length = Promt("Длина массива: ");
int min = Promt("Начальное значенние: ");
int max = Promt("Конечное значение: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);

/* Console.WriteLine("Введите элементы массива");
int[] array = int.Parse(String.Split(' ', Console.ReadLine()));
Console.WriteLine(String.Join(" ", array)); */