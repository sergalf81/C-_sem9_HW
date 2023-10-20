using System.Dynamic;

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

NaturalFromMaxToMin(number, count);

void NaturalFromMaxToMin(int n, int count)
{
    if(count > n)
    {
        return;
    }
    else
    {
        NaturalFromMaxToMin(n, count + 1);
        System.Console.Write(count + ", ");
    }
}
System.Console.WriteLine();
