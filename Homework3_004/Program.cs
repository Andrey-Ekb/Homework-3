// показать кубы чисел, заканчивающтиеся на четную цифру.
// все четные числа в кубе дают четную цифру.

Console.Clear();
Console.Write("введите крайнее число куба -");
int number= int.Parse(Console.ReadLine() ?? "0");

int rez=0;
int count=2;


while (count<=number && 0<count)
{
    rez=count*count*count;
    Console.WriteLine(rez);
    count=count+2;
}   
Console.WriteLine();
