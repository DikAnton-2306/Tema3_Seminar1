/* Console.Clear();
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
На вход трёхзначное число и на выход последнюю цифру этого числа
456->6    782->2  918->8
*/
Console.Clear();
Console.Write("Введите число N: ");
int N1 = int.Parse(Console.ReadLine());
int N2 = N1%10;
Console.WriteLine(N2);