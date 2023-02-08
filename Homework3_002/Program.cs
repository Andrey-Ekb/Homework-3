// Подсчитать сумму чисел.

Console.Clear();

Console.WriteLine();
Console.Write("Введите число от 0 до 1000 - ");
int number=int.Parse(Console.ReadLine() ?? "0");
int sum=0;

while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;

}

Console.WriteLine();
Console.WriteLine("Сумма цифр равна  "+sum);
Console.WriteLine();
