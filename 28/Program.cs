//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int s=int.Parse(Console.ReadLine());

int pr(int a)
{
    int x=1; 
    int i=1;
    for (i=2; i<=a; i++)
        {
            x=x*i;
           
        }
    return x;
}

Console.Write($"Ответ: {pr(s)}");
