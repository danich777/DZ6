
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Укажите, количество чисел: "); 
// int number = int.Parse(Console.ReadLine()!); 
// int[] array = GetArray(number, -999, 1000);
// Console.WriteLine(String.Join(", ", array));

// int posNum = 0;

// for  (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         posNum++;
//     }
// }

// Console.WriteLine($"Количество положительных чисел = {posNum}.");

//  int[] GetArray (int size, int minValue, int maxValue)
// {
//  int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.


Console.WriteLine("Введите значение k1: ");
float k1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b1: "); 
float b1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2: "); 
float k2 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2: "); 
float b2 = float.Parse(Console.ReadLine()!);
 
float x = 0; 
float y = 0;

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

if (k1 == k2) 
{
    Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} параллельны и не имеют точки пересечения");
}
else {
Console.WriteLine($"Координаты точки пересечения прямых: ({x}; {y})");
}
