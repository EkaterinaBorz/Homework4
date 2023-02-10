// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
int[] array = { 2, 32, 41, 15, 46, 70, 28, 91, 14, 18 };
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом = ");
Console.Write(max - min);