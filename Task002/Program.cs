Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int sqr = numberA / numberB;

if (sqr == numberB)
{
    Console.WriteLine("Первое числа являеться квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не являеться квадратом второго числа");
}