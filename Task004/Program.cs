Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = number  - (number*2) - 1;

while(number != sum){
    Console.Write(" " + number);
    number--;
}