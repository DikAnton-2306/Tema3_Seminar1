// Написать программу, которая на вход принимает число и выдаёт его квадрат
Console.Clear(); //Clear() очищает терминал
Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine()); //Parse() преобразовывает/конвертирует один тип данных в другой
int square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {square}");//$ обозначает, что есть {переменные}