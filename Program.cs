// Задача 25.
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Cycle(int A, int B)
{
    double result = A;
    for (int i = 1; i < Math.Abs(B); i++)
    {
        result *= A;
    }
    if (B > 0) Console.WriteLine($"Ответ = {result}");
    else if (B < 0) Console.WriteLine($"Ответ = {1 / result}");
}

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Cycle(A, B);

// Задача 27.
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void SumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine($"Сумма всех цифр = {sum}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
SumOfDigits(number);

// Задача 29.
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void RandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-33, 34);
    }
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
}

Console.Write("Чтобы сгенерировать массив, нажмите Enter.");
Console.ReadLine();
RandomArray();
