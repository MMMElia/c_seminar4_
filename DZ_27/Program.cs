// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Clear();
Console.Write("Введите число: ");
int n=int.Parse(Console.ReadLine());

int method(int a)
{
int i=0;
while (a>0)
    {
        i=i+a%10;
        a/=10;
    }
return i;
}

Console.Write($"Ответ: {method(n)}");
