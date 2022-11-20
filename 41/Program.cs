// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Введите количество чисел, которое неоходимо проверить");
int ArrayLengh = int.Parse(Console.ReadLine());
double [] nums = new double [ArrayLengh];
Console.WriteLine("Введите числа через enter и программа покажет сколько было введено положительных чисел");
for (int i=0; i<ArrayLengh;i++)
{
    nums [i] = double.Parse(Console.ReadLine());
}
int plus =0;
for (int i=0; i<ArrayLengh;i++)
{
    if (nums [i]>0) plus++;
}
Console.WriteLine($"Было введено {plus} положительных чисел");