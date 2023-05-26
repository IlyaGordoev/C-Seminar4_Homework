// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Method(int number)
{
    int sum = 0;

    for (int i = number; i > 0; i = i / 10)
    {
        sum += i % 10;
    }
    return sum;
}

System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int result = Method(a);
System.Console.WriteLine(result);
