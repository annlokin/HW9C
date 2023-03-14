// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputUser(string message)
{
    System.Console.Write($"{message} = ");
    return Convert.ToInt32(Console.ReadLine());
}

void AllEvenNumberBetween(int M, int N)
{
    if (M == N)
        return;
    Console.Write($"{N}");
    if (M % 2 != 0) return;
    AllEvenNumberBetween(M + 1, N - 1);
    return;
    AllEvenNumberBetween(M + 2, N - 1);
}

int numM = InputUser("Введите первое число: ");
int numN = InputUser("Введите второе число: ");
AllEvenNumberBetween(numM, numN);

