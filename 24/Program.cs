// сумма чисел от 1 до А

Console.Clear();
Console.Write("Введите число: ");
int n=int.Parse(Console.ReadLine());

int sum (int a) {
    int s=0;
    for (int i=1; i<=a; i++){
    s +=i;
          }
    return s;
}



Console.Write($"Ответ {sum(n)}");
