using System;
class Program
{
    static void Main(string[] args)
    {
        // Запитуємо ім'я користувача
        Console.Write("Введіть ваше ім'я: ");
        string userName = Console.ReadLine();

        // Виводимо привітання
        Console.WriteLine($"Вітаю {userName}!");
    }
}
