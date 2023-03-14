// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int InputUser(string message)
{
    System.Console.Write($"{message} = ");
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int M, int N)
{
    if (M==N) return M;
    return (N + Sum(M, N - 1));
}

int numM = InputUser("Введите первое число: ");
int numN = InputUser("Введите второе число: ");
Console.WriteLine($"{Sum(numM, numN)}");