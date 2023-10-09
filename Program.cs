// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите количество чисел: ");
//         int count = int.Parse(Console.ReadLine());

//         int positiveCount = 0;
//         for (int i = 0; i < count; i++)
//         {
//             Console.Write("Введите число: ");
//             int number = int.Parse(Console.ReadLine());

//             if (number > 0)
//             {
//                 positiveCount++;
//             }
//         }

//         Console.WriteLine($"Количество чисел больше 0: {positiveCount}");
//     }
// }


// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

namespace IntersectionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения k1, b1, k2 и b2:");

            // Считываем входные значения от пользователя
            double k1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double k2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            // Вычисляем значение x
            double x = (b2 - b1) / (k1 - k2);

            // Вычисляем значение y, подставляя x в одно из уравнений
            double y = k1 * x + b1;

            Console.WriteLine("Точка пересечения прямых имеет координаты ({0}, {1})", x, y);
        }
    }
}