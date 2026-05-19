using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UtilityLibraries;

namespace ShipLibraryTest
{
    [TestClass]
    public class ShipTests
    {
        [TestMethod]
        public void TestShipInitialization()
        {
            // Перевірка коректності створення об'єкта
            CargoShip cargo = new CargoShip("TestCargo", "Ніколаєв", 10000, "Петров", 10, DateTime.Now, 5000, "Контейнери", 8000);

            Assert.AreEqual("TestCargo", cargo.Name);
            Assert.AreEqual("Вантажний", cargo.Type);
            Assert.AreEqual(0.0, cargo.CurrentSpeed); // Швидкість має бути 0 спочатку
        }

        [TestMethod]
        public void TestChangeSpeedPositive()
        {
            // Перевірка збільшення швидкості
            CruiseLiner liner = new CruiseLiner("TestLiner", "Лондон", 20000, "Сміт", 50, DateTime.Now, 8000, 100, 50);

            liner.ChangeSpeed(15.5);

            Assert.AreEqual(15.5, liner.CurrentSpeed);
        }

        [TestMethod]
        public void TestChangeSpeedNegativeBounds()
        {
            // Перевірка, що швидкість не падає нижче нуля
            CargoShip cargo = new CargoShip("TestCargo", "Ніколаєв", 10000, "Петров", 10, DateTime.Now, 5000, "Контейнери", 8000);

            cargo.ChangeSpeed(-10.0);

            Assert.AreEqual(0.0, cargo.CurrentSpeed);
        }
    }
}