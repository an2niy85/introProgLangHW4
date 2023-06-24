// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string meassage)
{
    Console.Write(meassage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Power(int powerbase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerbase;
    }
    return power;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

Console.Clear();
int powerBase = Promt("Введите основание: ");
int exponent = Promt("Введите показатель: ");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}

/* int[] twoNumbers()
{
    Console.WriteLine("Введите два числа, а я возведу первое в степень второго.");
    int i = 0;
    int[] num = new int[2];
    for (i = 0; i < num.Length; i++)
    {
        Console.Write($"{i + 1} число: ");
        num[i] = Convert.ToInt32(Console.ReadLine());    
    }
    return num;
}

void numberToPower(int[] num)
{
    int i = 0;
    int result = 1;
    for (i = 1; i <= num[1]; i++)
    {
        result *= num[0]; 
    }
    System.Console.WriteLine($"{num[0]} в степени {num[1]} равно {result}");
}

int[] arr = twoNumbers();
numberToPower(arr); */