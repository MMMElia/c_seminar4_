// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21


Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string n = Console.ReadLine();

int[] newarray(string n1) // Метод перевода в массив введенной с клавиатуры
{
    string[] s = n1.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
        array[i] = int.Parse(s[i]);
    }
    return array;
}



void otvet(int[] array) 
{
int b=array.Length/2;

    for (int i=0; i<b; i++)  
    {
        Console.Write($"{array[i]*array[array.Length-1-i]}, ");
    }
if (array.Length%2==1) Console.Write($"{array[b]}");  //Проверяю серединный элемент если данный массив с размером нечетным
}

int[] arr1=newarray(n);
otvet(arr1);






