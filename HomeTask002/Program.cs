Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите вервое число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());

if (numberA > numberB && numberA > numberC) {Console.WriteLine($"Число {numberA} максимальное из данных");}
if (numberB > numberA && numberB > numberC) {Console.WriteLine($"Число {numberB} максимальное из данных");}
if (numberC > numberA && numberC > numberB) {Console.WriteLine($"Число {numberC} максимальное из данных");}
