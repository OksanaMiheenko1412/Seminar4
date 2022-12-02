// task28 - программа на вход принимает число N и выдает произведение чисел от
// 1 до N, например: 4 ->24; 5 ->120, нахождение факториала
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= n; i++)
    result *= i; // result = result * i
Console.WriteLine($"Результат: {result}");    