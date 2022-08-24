// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

string str = num.ToString();
int minLength = 2;

if(str.Length > minLength)
{
    Console.WriteLine($"{num} -> {str[2]}");
}
else
    Console.WriteLine(num + " -> третьей цифры нет.");

