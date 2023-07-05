
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number * number;
Console.WriteLine("Квадрат числа равен: " + sqr);
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine("Второй пример квадрата числа: " + sqr1);



