System.Console.Write($" Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write($" Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;


if( a > max ) max = a;
if( a < max ) min = a;
if( b > max ) max = b;
if( b < max ) min = a;

System.Console.Write($"max - ");
System.Console.WriteLine(max);
System.Console.Write($"min - ");
System.Console.WriteLine(min);