// массив из 0 и 1 рандомно

Console.Clear();
Console.Write("Введите число: ");
int n=int.Parse(Console.ReadLine());

int[]arr=Input(n);

int[] Input(int n1) 
{
int[] array= new int[n1];
int i=0;
for (i=0; i<n1; i++)
    {
        array[i]=new Random().Next(0,2);
        Console.Write($"{array[i]} ");
    }
return array;
}

