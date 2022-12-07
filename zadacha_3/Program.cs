// Console.Clear(); //Clear() очищает терминал
// Console.Write("Введите первое число (квадрат): ");
// int numberA = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine());
// if (numberA == numberB*numberB)
// {
//     Console.WriteLine("Да, первое число является квадратом второго");
// }
// else
// {
//     Console.WriteLine("НЕТ, первое число НЕ является квадратом второго");
// }

Console.Clear();
Console.Write("Введите число N: ");
int count=0;
int number = int.Parse(Console.ReadLine());
if (number>0)
{
count=number*(-1);
    while(count<=number)
    {
        Console.Write($"{count}, ");
    count++;
    }
}
else
{
    count=number;
    while(count<=number*(-1))
    {
        Console.Write($"{count}, ");
        count++;
    }
}