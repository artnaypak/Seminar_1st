// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

System.Console.WriteLine("Введите первое число: ");
string inputString1 = Console.ReadLine();
System.Console.WriteLine("Введите второе число: ");
string inputString2 = Console.ReadLine();
int value1 = Convert.ToInt32(inputString1);
int value2 = Convert.ToInt32(inputString2); 
int square = value1 * value1;
if (square == value2)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}