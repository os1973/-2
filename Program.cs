/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число:");
string first = Console.ReadLine();
int number1 = int.Parse(first);
Console.WriteLine("Введите второе число");
string second = Console.ReadLine();
int number2 = int.Parse(second);

if(number1 > number2);
{
    Console.WriteLine($"{first} больше чем {second}");
}
if(number1 < number2);
{
    Console.WriteLine($"{first} меньше чем {second}");
}


