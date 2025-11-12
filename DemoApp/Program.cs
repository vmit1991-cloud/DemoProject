using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть ваше ім'я: ");
string userName = Console.ReadLine();
Console.Write("Введіть ваш вік: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"Користувач: {userName}, Вік: {age}");

    }
}
