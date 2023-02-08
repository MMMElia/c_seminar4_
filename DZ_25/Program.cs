// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите первое число: ");
int a=int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=int.Parse(Console.ReadLine());

int method(int x, int y) 
{
    int i=1;
    int p=1;
    for (i=1; i<=y;i++)
    {
        p=p*x;
    }
return p;
}

Console.Write($"Ответ {method(a,b)} ");
