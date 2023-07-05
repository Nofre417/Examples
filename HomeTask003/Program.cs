Console.Clear();
Console.Write("Введите число для проверки: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)  Console.WriteLine("Число делиться на два без остатка");
else Console.WriteLine("Число не делиться на два без остатка");