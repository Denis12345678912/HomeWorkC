// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int [] numbers = new int [3];
int theNumberMax =0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < numbers.Length; i++)
{
    if(theNumberMax < numbers[i])
    {
        theNumberMax = numbers[i];
    }
}
Console.WriteLine("Самое максимальное число: " + theNumberMax);