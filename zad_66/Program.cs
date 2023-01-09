// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int NumberPlus(int num, int count, int sum)
{
    if (count <= num)
    {
        sum = count + NumberPlus(num, count + 1, sum);
    }
    return sum;
}
int sum = 0;
int numberM = AddNumber("Введите число M");
int numberN = AddNumber("Введите число N");

int result = NumberPlus(numberN, numberM, sum);
System.Console.WriteLine(result);