// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.Write("Введите размер массива: ");
int n=int.Parse(Console.ReadLine());

int[] arr=print(n);

int[] print(int n1) 
{
    int[] array = new int [n1];
    int i=0;
    for (i=0; i<n1; i++)
    {
        array[i]= new Random().Next(1,11);
        Console.Write($"{array[i]} ");
    }
return array;
}