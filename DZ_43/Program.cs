// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Clear();
Console.WriteLine("Чтобы найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ");
Console.WriteLine("необходимо ввести значения b1, k1, b2 и k2 ");
Console.Write("введите значение b1:");
float b1=float.Parse(Console.ReadLine());
Console.Write("введите значение k1:");
float k1=float.Parse(Console.ReadLine());
Console.Write("введите значение b2:");
float b2=float.Parse(Console.ReadLine());
Console.Write("введите значение k2:");
float k2=float.Parse(Console.ReadLine());



otvet(b1,k1,b2,k2);

void otvet(float b_1, float k_1,float b_2, float k_2)
{
    float x=(b_2-b_1)/(k_1-k_2);
    float y=k_1*x+b_1;
    Console.Write ($"Точка пересечения {x};{y}");
}
