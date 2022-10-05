Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
int firstNumber = 1;


while (firstNumber <= number)
{
    if (firstNumber % 2 == 0)
        Console.Write(firstNumber + ", ");
    firstNumber++;
}
