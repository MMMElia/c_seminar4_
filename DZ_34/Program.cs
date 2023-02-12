// Задайте массив заполненный
//случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Clear();
Console.Write("Введите размерность одномерного массива: ");
int n=int.Parse(Console.ReadLine());

int[] input(int n1) // ввод данных в массив
{
    int[] array=new int[n1];
    for (int i=0; i<n1; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
return array;
}

int otvet(int[] array,int n1) // поиск кол-ва четных чисел
{
    int k=0;
    for (int i=0; i<n1;i++)
    {
        if (array[i]%2==0) 
        {
            k++;
            Console($"{array[i]} ");  // вывод четных чисел массива для проверки
        }
    }
return k;
}



int[] arr=input(n);

for (int i=0; i<n; i++) // печать для проверки
{
Console.Write($"{arr[i]} ");
}

Console.Write($"Ответ: {otvet(arr,n)}");

