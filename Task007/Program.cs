using System;

Console.Clear();

int[] numbers = new int [] {2, 5, 13, 7, 6, 4};

int size = 6, sum = 0, avg = 0, index = 0;

while(index < size)
{
    sum = sum + numbers[index];
    index++;
}
avg = sum / size;

Console.WriteLine($"Answer: {avg}");