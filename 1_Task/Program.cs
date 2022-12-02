///Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите 2 числа");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
if (a>b) 
Console.WriteLine($"число {a} больше числа {b}");
else if (a<b) 
Console.WriteLine($"число {a} меньше числа {b}");
else
Console.WriteLine ($"числа {a} {b} равны");