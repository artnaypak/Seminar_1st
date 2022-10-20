//  Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

System.Console.WriteLine("Введите число, соответствующее дню недели: ");
string value = Console.ReadLine(); 
int weekday = Convert.ToInt32(value);

if (weekday == 1) System.Console.WriteLine("Понедельник");
if (weekday == 2) System.Console.WriteLine("Вторник");
if (weekday == 3) System.Console.WriteLine("Среда");
if (weekday == 4) System.Console.WriteLine("Четверг");
if (weekday == 5) System.Console.WriteLine("Пятница");
if (weekday == 6) System.Console.WriteLine("Суббота");
if (weekday == 7) System.Console.WriteLine("Воскресенье");

