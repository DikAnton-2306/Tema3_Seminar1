// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 3. Написать программу, которая будет выдавать название дня недели по заданному номеру
Console.Clear(); //Clear() очищает терминал
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 1) Console.WriteLine ("Это - понедельник");
if (number == 2) Console.WriteLine ("Это - вторник");
if (number == 3) Console.WriteLine ("Это - среда");
if (number == 4) Console.WriteLine ("Это - четверг");
if (number == 5) Console.WriteLine ("Это - пятница");
if (number == 6) Console.WriteLine ("Это - суббота");
if (number == 7) Console.WriteLine ("Это - воскресенье");