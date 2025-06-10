using NUnit.Framework;
using System;
using CarLibrary;

namespace CarLibrary.UnitTests
{
    [TestFixture]
    public class CarUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var car = CreateTestCar();
            Assert.That(car.Brand, Is.EqualTo("Toyota"));
            Assert.That(car.Year, Is.EqualTo(2020));
            Assert.That(car.VIN, Is.EqualTo("JTDBR32E720123456"));
            Assert.That(car.BodyType, Is.EqualTo(CarBodyType.Sedan));
        }

        [Test]
        public void GetInfoTest()
        {
            var car = CreateTestCar();
            var info = car.GetInfo();
            Console.WriteLine("info[0] = " + info[0]);
            Console.WriteLine("info[1] = " + info[1]);
            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo($"Марка: Toyota, Год: 2020, VIN: JTDBR32E720123456, Тип кузова: {CarBodyType.Sedan}"));
            Assert.That(info[1], Is.EqualTo("Цена: 1500000 руб., Дата продажи: 15.10.2024, Покупатель: Иванов Иван Иванович"));
        }

        private Car CreateTestCar()
        {
            var car = new Car("Toyota", 2020, "JTDBR32E720123456", CarBodyType.Sedan);
            car.Price = 1500000;
            car.SaleDate = new DateTime(2024, 10, 15);
            car.BuyerFullName = "Иванов Иван Иванович";
            return car;
        }
    }
}
