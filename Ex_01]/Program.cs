Console.WriteLine ("Ведите число А ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число В ");
int numberB = int.Parse(Console.ReadLine());
double result = Math.Pow(numberB,2);
if (numberA == result)
{
System.Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else
{
  System.Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");  
}
