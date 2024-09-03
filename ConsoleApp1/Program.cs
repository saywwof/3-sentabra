using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое неотрицательное число для вычисления факториала:");

        //Чтение ввода пользователя
        string input = Console.ReadLine();
        int number;

        //Проверка на корректность ввода
        if (int.TryParse(input, out number) && number >= 0)
        {
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"Факториал {number} = {factorial}");
        }
        else
        {
            Console.WriteLine("Ошибка: введите неотрицательное целое число.");
        }


    }
    //Метод для вычисления факториала
    static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}