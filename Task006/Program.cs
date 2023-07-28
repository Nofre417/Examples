using System;
using static System.Console;

//LALALALALLA

Clear();

int count = 0;

while(count != 5)
{
int number = new Random().Next(10, 100);

int a1 = number / 10;
int a2 = number % 10;

if (a1>a2)
{
    WriteLine("First way");
    WriteLine($"{number}->{a1}");
}
else
{
    WriteLine("Second way");
    WriteLine($"{number}->{a2}");
}
count++;
}