// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
//Console.Write("Введите размерность массива: ");
//int m=Console.ReadLine();

Console.Write($"Введите элементы массива через пробел: ");
string n = Console.ReadLine();

int[] arr1=newarray(n);

otvet(arr1);

//Console.Write($"Ответ: {s} ");

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
    int k=0; 
    for (int i=0; i<array.Length; i++)  
    {
        if (array[i]>0) k++;
    }
    Console.Write($"Ответ: {k} ");
}


