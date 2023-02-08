// Написать программу вычисления произведения чисел от 1 до N.

Console.Clear();
System.Console.WriteLine();
Console.Write("Введите число:   ");

int number = int.Parse( Console.ReadLine() ?? "0");
int rez=1;
int count=1;

while (count<=number)
{
    rez=rez*count;
    count++;
}

Console.WriteLine();
Console.WriteLine("Произведение чисел от 1 до "+number+" равно "+rez);
Console.WriteLine();