Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите вервое число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB) Console.WriteLine($"Число {numberA} больше числа {numberB}");
else if (numberA < numberB) Console.WriteLine($"Число {numberB} больше числа {numberA}");
else{
    Console.WriteLine($"Число {numberA} равно {numberB}");
}
