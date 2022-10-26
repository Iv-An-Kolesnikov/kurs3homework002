//13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
int i = 10;
int j = 1;
Console.Write("Введите пожалуйста число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.Write($"{num} -> Третьей цифры нет");
while ( i >= 1)
{
    if ((num > (10 * i) - 1) & (num < (100 * i) - 1)) 
    {
        Console.Write($"{num} -> {(num % i) / j}");
        break;
    }
    else 
    {
        i = i * 10;
        j = j * 10;
    }
}