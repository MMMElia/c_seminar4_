// Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

Console.Clear();

int[] input()
{
    int[] array=new int[123];
    
    for (int i=0; i<123;i++) // заполнение массива
    {
        array[i]=new Random().Next(1,1000);  
    }
    Console.Write(" ");
    for (int i=0; i<123;i++) // вывод полученного массива
    {
        Console.Write($"{array[i]} ");
    }
    return array;
}

int otvet(int[] array) // подсчет ответа
{
    int s=0;
    for (int i=1; i<123; i=i+1)
    {
        if (array[i]<=99 && array[i]>=10) s++;
    }
return s;
}

int[] arr=input();

Console.Write($"Ответ: {otvet(arr)}");


