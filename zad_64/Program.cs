// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void NumberPlus(int num, int count)
{
    if (count >= 1)
    {
        System.Console.Write(count + " ");
        count--;
        NumberPlus(num, count);
    }
}
int number = AddNumber("Введите число");
int count = number;
NumberPlus(number, count);