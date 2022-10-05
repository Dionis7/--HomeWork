Console.WriteLine("введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("это максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("это максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("это максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("это максимальное число: " + thirdNumber);
}
