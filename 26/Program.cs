// Напишите программу, которая принимает 
// на вход число N и выдаёт количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int n=Int32.Parse(Console.ReadLine());


int s=num(n);
Console.Write($"Ответ: {s}");

int num(int a1) {
    int i=0;
    if (a1<0) {a1*=(-1);}
    while (a1>0) {
        i++;
        a1/=10;
       
            }
return num;
}