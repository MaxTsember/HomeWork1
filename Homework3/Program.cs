﻿//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int remDiv = number % 2;

if(remDiv == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}