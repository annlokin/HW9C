// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int InputUser(string message)
{
    System.Console.Write($"{message} = ");
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}


int numM = InputUser("Введите число m: ");
int numN = InputUser("Введите число n: ");
Console.WriteLine($"{AckermannFunction(numM, numN)}");
