//Console.Write("Введите любое число: ");
//int number = int.Parse(Console.ReadLine());//Parse() преобразовывает/конвертирует один тип данных в другой
//int square = number * number;
//Console.WriteLine($"Квадрат числа {number} равен {square}");//$ обозначает, что есть {переменные}

// Задача 1. Написать программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// a = 25, b = 5 ->да
// a = 2, b = 10 ->нет
// a = 9, b = -3 ->да
// a = -3, b = 9 ->нет
Console.Clear(); //Clear() очищает терминал
Console.Write("Введите первое число (квадрат): ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("НЕТ, первое число НЕ является квадратом второго");
}

// Задача 3. Написать программу, которая будет выдавать название дня недели по заданному номеру