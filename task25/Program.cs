// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Degree(int num, int deg)
{
int res = 1;
    for (int i = 0 ; i < deg; i++)
        {
        res *= num;
        }
    return res;
}

Console.WriteLine("Введите число (А)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа (В)");
int b = Convert.ToInt32(Console.ReadLine());
int result = Degree(a, b);
Console.WriteLine($"{a} в степени {b} = {result}");