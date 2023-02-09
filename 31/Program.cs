//Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

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
int max=0;
int min=0;
for (i=0;i<s1;i++)
{
if (array[i]>0) {max=max+array[i];}
if (array[i]<0) {min=min+array[i];}

}

Console.Write($"Max {max} ");
Console.Write($"Min {min} ");
return array;
}