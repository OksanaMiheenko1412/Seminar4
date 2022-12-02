// taskmaxof2 найти максимум среди 2 чисел

void maxNumbers(ref int n)//  - процедура
{
    n = n + 10;  
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
maxNumbers(ref n);
Console.WriteLine($"Результат: {n}");