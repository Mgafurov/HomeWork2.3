/*Перемножить 3 числа между собой
Ввод: 3 целых числа
Вывод: 1 целое число
*/

using System;

class HomeWork
{
    static void Main()
    {
        Console.WriteLine("Введите три целых числа : ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int sum = number1 * number2 * number3;
        Console.WriteLine("Целое число  " + sum);
        Console.ReadKey();
    }
}
