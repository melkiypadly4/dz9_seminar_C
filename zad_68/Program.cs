// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int EnterNumber(string messag)
{
    System.Console.Write($"{messag} => ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FunctionAkkerman(int N, int M)
{
    if (N == 0)
    {
        return M + 1;
    }
    else if ((N != 0) && (M == 0))
    {
        return FunctionAkkerman(N - 1, 1);
    }
    else
    {
        return FunctionAkkerman(N - 1, FunctionAkkerman(N, M - 1));
    }
}
int NumberN = EnterNumber("Введите неотрицательное число M");
int NumberaM = EnterNumber("Введите неотрицательное число N");
int result = FunctionAkkerman(NumberN, NumberaM);
System.Console.WriteLine($"Функция  Аккермана чисел ({NumberN},{NumberaM}) = {result}");

