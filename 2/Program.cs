using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        //Подсчет количества символов
        int characterCount = input.Length;

        //Подсчет количества слов
        string[] words = input.Split(new char[] { ' ', '\t', '\n' }, 
            StringSplitOptions.RemoveEmptyEntries);
        int wordCount = words.Length;

        //Подсчет количества предложений
        char[] sentencesDelimmiters = { '.', '!', '?' };
        string[] sentences = input.Split(sentencesDelimmiters, StringSplitOptions.RemoveEmptyEntries);
        int sentenceCount = sentences.Length;

        //Вывод результатов
        Console.WriteLine($"Количество символов: {characterCount}");
        Console.WriteLine($"Количество слов: {wordCount}");
        Console.WriteLine($"Количество предложений: {sentenceCount}");


        //Задержка перед закрытием консоли
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

}
