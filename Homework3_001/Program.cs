// Найти куб чисел от 1 до N/

Console.Clear();

Console.Write("Введите число - ");
double number=int.Parse(Console.ReadLine() ?? "0");
double rez=Math.Pow(number,3);

Console.WriteLine();
Console.WriteLine("Куб числа - "+number+" равeн "+rez);
Console.WriteLine();

