// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumNumbers(int start, int end)
{
    if (start > end) return 0;
    return start + SumNumbers(++start, end);
}

int start = InputNum("Введите целое положительное число начало отрезка: ");
int end = InputNum("Введите целое положительное число конец отрезка: ");
Console.WriteLine($"\nСумма чисел в промежутке от {start} до {end} равна {SumNumbers(start, end)}\n");