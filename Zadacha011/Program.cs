﻿int number = RandomInt(100, 999);
int numberA = number / 100;
int numberB = number % 10;
Console.WriteLine(number);
//Console.Write(numberA);
//Console.Write(numberB);
Console.WriteLine(Convert.ToString(numberA) + Convert.ToString(numberB));

int RandomInt(int min, int max)
{
    return new Random().Next(min, max);
}