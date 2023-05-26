// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array(int Length, int MinValue, int MaxValue)
{
int[] array = new int[Length];
for (int i = 0; i < Length; i++)
{
    int numberA = new Random().Next(MinValue, MaxValue + 1);
    array[i] = numberA;
}
return array;
}

System.Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение массива");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение массива");
int c = Convert.ToInt32(Console.ReadLine());

int[] result = Array(a, b, c);
System.Console.WriteLine(string.Join(", ", result));