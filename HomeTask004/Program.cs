Console.Clear();   
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
int count = 0;

while(count < number){
    count++;
    if (count % 2 == 0) Console.WriteLine(count  +" ");
}