// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.WriteLine("Программа ищет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; введите значения k1, b1, k2 и b2");
double [,] Coefficient = new double [2,2];
void Explain (int k, int b)
{
    if (b==0) Console.Write($"k{k+1} = ");
    else Console.Write($"b{k+1} = ");
}
for (int k =0; k<Coefficient.GetLength(0); k++)
{
    for (int b =0; b<Coefficient.GetLength(1); b++)
    {
        Explain (k, b);
        Coefficient [k,b] = double.Parse(Console.ReadLine());
    }
}
double [] Coordinates = new double [2];
if (Coefficient[0, 0] == Coefficient [1,0]) Console.WriteLine("Линии параллельны");
else
{
    Coordinates [0] = (Coefficient[1,1]-Coefficient[0,1])/(Coefficient[0,0]-Coefficient[1,0]);
    Coordinates [1] = Coefficient[0,0]*Coordinates[0] +Coefficient[0,1];
    Console.WriteLine($"Прямые пересекаются в точке [{Coordinates [0]}; {Coordinates [1]}]");
}
