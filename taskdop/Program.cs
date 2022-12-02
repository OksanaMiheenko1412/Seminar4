// taskdop - задача "сбор черники"
Console.Clear();
Console.Write("Введите количество кустов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
int resultSum = 0;
 
for (int i = 0; i < arrayFirst.Length; i++)
    arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < arrayFirst.Length; i++) 
{

    if (arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1] > resultSum)
        resultSum = arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1];
}

if (arrayFirst[0] + arrayFirst[1] + arrayFirst[n - 1] > resultSum)
    resultSum = arrayFirst[0] + arrayFirst[1] + arrayFirst[n - 1];

if  (arrayFirst[0] + arrayFirst[n - 1] + arrayFirst[n - 2] < resultSum)
    resultSum = arrayFirst[0] + arrayFirst[n - 1] + arrayFirst[n - 2]; 

Console.WriteLine(resultSum);     
