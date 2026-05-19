using System;

namespace UtilityLibraries
{
    // Базовий клас
    public class Ship
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string HomePort { get; set; }
        public double Displacement { get; set; }
        public string CaptainName { get; set; }
        public int CrewCount { get; set; }
        public DateTime LaunchDate { get; set; }
        public double EnginePower { get; set; }
        public double CurrentSpeed { get; protected set; }

        // Конструктор базового класу
        public Ship(string name, string type, string homePort, double displacement,
                    string captainName, int crewCount, DateTime launchDate, double enginePower)
        {
            Name = name;
            Type = type;
            HomePort = homePort;
            Displacement = displacement;
            CaptainName = captainName;
            CrewCount = crewCount;
            LaunchDate = launchDate;
            EnginePower = enginePower;
            CurrentSpeed = 0.0; // Початкова швидкість
        }

        // Метод зміни швидкості
        public void ChangeSpeed(double amount)
        {
            CurrentSpeed += amount;
            if (CurrentSpeed < 0) CurrentSpeed = 0; // Швидкість не може бути негативною
        }
    }

    // Похідний клас: Вантажний корабель
    public class CargoShip : Ship
    {
        public string CargoType { get; set; }
        public double CargoCapacity { get; set; }

        // Конструктор з передачею параметрів у базовий за допомогою 'base'
        public CargoShip(string name, string homePort, double displacement, string captainName,
                         int crewCount, DateTime launchDate, double enginePower,
                         string cargoType, double cargoCapacity)
            : base(name, "Вантажний", homePort, displacement, captainName, crewCount, launchDate, enginePower)
        {
            CargoType = cargoType;
            CargoCapacity = cargoCapacity;
        }
    }

    // Похідний клас: Круїзний лайнер
    public class CruiseLiner : Ship
    {
        public int OccupiedSeats { get; set; }
        public int FreeSeats { get; set; }

        public CruiseLiner(string name, string homePort, double displacement, string captainName,
                           int crewCount, DateTime launchDate, double enginePower,
                           int occupiedSeats, int freeSeats)
            : base(name, "Круїзний лайнер", homePort, displacement, captainName, crewCount, launchDate, enginePower)
        {
            OccupiedSeats = occupiedSeats;
            FreeSeats = freeSeats;
        }
    }
}