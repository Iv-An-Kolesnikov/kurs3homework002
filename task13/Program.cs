//13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// ЗАДАЧА НЕ РЕШЕНА!!

Console.Clear();
Console.Write("Введите пожалуйста число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.Write($"{num} -> Третьей цифры нет");
if ((num > 99) & (num < 999)) Console.Write($"{num} -> {num % 10}");
// num > 1000
int i = 10;
int j = 10;
int num1 = 0;
int num2 = 0;
while (i >= 1)
{
    if ((num > 99*i) & (num < 999*i)) 
    {
        num1 = (num / i) % i;
        num2 = num1 % (i / j);

        Console.WriteLine($"{num} -> {num1} -> {num2}");
        Console.Write(i);
        break;
    }
    else 
    {
        i = i * 10;
        j = j * 10;
    }
}