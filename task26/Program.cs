// task26 программа,которая принимает на вход число и выдает количество цифр в числе
// например: 456 ->3; 78 ->2; 89126 ->5
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = 1;// длина числа
while (n / 10 != 0)// пока последнее число неравно 0
{
    n /= 10; //отбрасываем последнюю цифру числа
    size++; //увеличиваем переменную size на единицу
}
Console.WriteLine(size);
