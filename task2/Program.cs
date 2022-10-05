
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



Console.WriteLine(" введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine(" введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());


if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " > " + secondNumber);
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine(secondNumber + " > " + firstNumber);
}
else
{
    Console.WriteLine(secondNumber + " = " + firstNumber);
}