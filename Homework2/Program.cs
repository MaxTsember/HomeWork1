﻿//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int max = 0;

Console.Write("InputFirstNumber: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("InputSecondNumber: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("InputThirdNumber: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > max)
{
    max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

Console.WriteLine("max = " + max);
