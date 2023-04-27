// напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// например 4 -> 16
//          3-> 9
//          7-> 49

// 1. принимать число?
// 2. посчитать квадрат
// 3. вывести число

string b = Console.ReadLine();
int a = Convert.ToInt32(Console.ReadLine());  //int a = Convert. ToInt32(Console.ReadLine()); вместо 2-ух первых строк
int result = a * a;
Console.WriteLine(result);
