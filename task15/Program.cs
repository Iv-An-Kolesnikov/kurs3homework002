//15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите пожалуйста число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > 0) & (num <= 5)) Console.Write($"{num} -> Нет");
if ((num == 6) || (num == 7)) Console.Write($"{num} -> Да");
if (num > 7) Console.Write("Число не входит в диапазон");