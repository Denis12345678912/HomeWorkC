// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два числа");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine($"{number1} - большее, а {number2} - меньшее");
}
else if  (number2 > number1)
{
Console.WriteLine($"{number2} - большее, а {number1} - меньшее");
}
else if (number1 == number2)
{
    Console.WriteLine ($"{number1} равен {number2}");
}