// Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int n=int.Parse(Console.ReadLine());

int[] input(int n1)
{
    int[] array=new int[n1];
    Console.WriteLine("Введите мин значение массива ");
    int x=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите макс значение массива ");
    int y=int.Parse(Console.ReadLine());
    for (int i=0; i<n1;i++) // заполнение массива
    {
        array[i]=new Random().Next(x,y);  
    }
    Console.Write(" ");
    for (int i=0; i<n1;i++) // вывод полученного массива
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}

int otvet(int[] array, int n1) // подсчет сумм позиций на нечетных
{
    

    int s=0;
    for (int i=1; i<n1; i=i+2)
    {
        s=s+array[i];
    }
return s;
}

int[] arr=input(n);

Console.Write($"Ответ: {otvet(arr,n)}");


