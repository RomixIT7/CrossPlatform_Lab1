using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== Демонстрація роботи бібліотеки кораблів ===");

        // Створюємо вантажний корабель
        CargoShip cargo = new CargoShip(
            "Mersin-1", "Одеса", 50000, "Іваненко П.Р.", 24,
            new DateTime(2020, 5, 12), 15000, "Зерно", 40000
        );

        // Створюємо круїзний лайнер
        CruiseLiner liner = new CruiseLiner(
            "Ocean Dream", "Майамі", 120000, "John Smith", 350,
            new DateTime(2022, 11, 23), 45000, 1200, 300
        );

        // Виводимо початковий стан
        PrintShipInfo(cargo);
        PrintShipInfo(liner);

        // Змінюємо швидкість
        Console.WriteLine("\n--- Кораблі починають рух ---");
        cargo.ChangeSpeed(18.5);
        liner.ChangeSpeed(24.0);

        PrintShipInfo(cargo);
        PrintShipInfo(liner);

        Console.WriteLine("\nНатисніть Enter для виходу...");
        Console.ReadLine();
    }

    static void PrintShipInfo(Ship ship)
    {
        Console.WriteLine($"Корабель: {ship.Name} ({ship.Type}) | Капітан: {ship.CaptainName} | Поточна швидкість: {ship.CurrentSpeed} вузлів");
    }
}