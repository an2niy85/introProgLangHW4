// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
//Console.WriteLine("Ввдеите число");
//int number = Convert.ToInt32(Console.ReadLine());
int number = Prompt("Введите число: ");
//int result = SumDigits(number);
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumDigits(number)}");

int SumDigits(int num)
{
    int res = 0;
    while (num != 0)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}

int Prompt(string meassage)
{
    Console.Write(meassage);
    int result = int.Parse(Console.ReadLine());
    return result;
}