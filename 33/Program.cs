// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.

Console.Clear();

Console.Write("Введите размер массива: ");
int s=int.Parse(Console.ReadLine());
Console.Write("Введите размер массива x: ");
int x=int.Parse(Console.ReadLine());
Console.Write("Введите размер массива y ");
int y=int.Parse(Console.ReadLine());


int[] arr=print(s,x,y);

int[] print(int s1, int x1, int y1) 
{
    int[] array = new int [s1];
    int i=0;
    for (i=0; i<s1; i++)
    {
        array[i]= new Random().Next(x1,y1+1);
        Console.Write($"{array[i]} ");
    }
Console.WriteLine(" ");
for (i=0;i<s1;i++)
{
array[i]=array[i]*(-1);
Console.Write($"{array[i]} ");
}

return array;
}