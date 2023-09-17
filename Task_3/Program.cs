// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int AckermannFunction(int start, int end)
{
    if (start == 0) return end + 1;
    else if (end == 0) return AckermannFunction(start - 1, 1);
    else return AckermannFunction(start - 1, AckermannFunction(start, end - 1));
}

int start = InputNum("Введите первое число (целое положительное число): ");
int end = InputNum("Введите второе число (целое положительное число): ");
Console.WriteLine($"\nФункция Аккермана для {start} и {end} равна {AckermannFunction(start, end)}\n");