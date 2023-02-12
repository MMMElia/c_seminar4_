// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int n=int.Parse(Console.ReadLine());

double[] input(int n1)
{
    double[] array=new double[n1];
    
    for (int i=0; i<n1;i++) // заполнение массива
    {
        array[i]=new Random().Next(1,10);  
    }
    Console.Write(" ");
    for (int i=0; i<n1;i++) // вывод полученного массива
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}

double otvet(double[] array, int n1) // поиск ответа
{
    double max=array[0]; double min=array[0];
    double s=0;
    for (int i=1; i<n1; i++)
    {
        if (array[i]>max) max=array[i];
        if (array[i]<min) min=array[i];
    }
Console.WriteLine(" ");
Console.Write($"Max {max}");
Console.WriteLine(" ");
Console.Write($"Min {min}");
Console.WriteLine(" ");
s=max-min;
return s;
}

double[] arr=input(n);

Console.WriteLine($"Ответ: {otvet(arr,n)}");
